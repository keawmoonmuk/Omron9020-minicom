using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiNationalIDCard.NET.Models;  //import library smartcard
using ThaiNationalIDCard.NET;
using smartcard_omron.Models;
using System.IO.Ports;
using System.Globalization;
using PCSC;

namespace smartcard_omron
{
    public partial class Metro : MetroFramework.Forms.MetroForm
    {
        private static ThaiNationalIDCardReader cardReader;
        private static PersonalPhoto personalPhoto;

        Patients patient = new Patients();  //import patient
        static bool _continue;
        static SerialPort _serialport;
        Data data = new Data();
    
        Timer t = new Timer();
        public Metro()
        {
            InitializeComponent();


            try
            {

                cardReader = null;
                personalPhoto = null;
                cardReader = new ThaiNationalIDCardReader();  // new method
                personalPhoto =  cardReader.GetPersonalPhoto();

                if (personalPhoto.CitizenID == patient.IDCard) return;

                ReadSmartcard(personalPhoto);

                timer_checksmartcard.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
               
                timer_checksmartcard.Start();
            }

        }
        //timer form smartcard
        public  void timer_checksmartcard_Tick(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    cardReader = null;
                    personalPhoto = null;
                    cardReader = new ThaiNationalIDCardReader();  // new method
                    personalPhoto = cardReader.GetPersonalPhoto();

                    if (personalPhoto.CitizenID == patient.IDCard) return;

                    ReadSmartcard(personalPhoto);  // read smartcard

                    timer_readdata.Start();
                }
                catch
                {
                 
                    metroTxt_status.CustomBackground = true;
                    metroTxt_status.CustomForeColor = true;
                
                    metroTxt_status.Text = "กรุณาเสียบบัตรประชาชน...";
                    metroTxt_status.BackColor = Color.Red;
                    metroTxt_status.ForeColor = Color.Black;
                    metroTxt_status.Font = new Font("Arial", 35, FontStyle.Bold);

                    break;
                }
           
            }
        }

   
        //timer readdata form omron
        public void timer_readdata_Tick(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    cardReader = null;
                    personalPhoto = null;
                    cardReader = new ThaiNationalIDCardReader();  // new method
                    personalPhoto = cardReader.GetPersonalPhoto();

                    //if (personalPhoto.CitizenID == idc) return;

                    metroTxt_status.BackColor = Color.Yellow;
                    metroTxt_status.ForeColor = Color.Black;
                    metroTxt_status.Font = new Font("Arial", 35, FontStyle.Bold);
                    metroTxt_status.Text = "รอข้อมูลจาก เครื่องวัด...";

                    ReaddataOmron();                // read data for omron

                    return;
                }
                catch
                {

                    metroTxt_status.CustomBackground = true;        
                    metroTxt_status.CustomForeColor = true;

                    metroTxt_status.Text = "กรุณาเสียบบัตรประชาชน...";
                    metroTxt_status.BackColor = Color.Red;
                    metroTxt_status.ForeColor = Color.Black;
                    metroTxt_status.Font = new Font("Arial", 35, FontStyle.Bold);

                    break;
                }

            }
        }

        //read serialport for bp 9020
        public  void ReaddataOmron()
        {

            try
            {
                //connect is com3
                _serialport = new SerialPort();
                _serialport = new SerialPort("COM3", 2400, Parity.Even, 8, StopBits.One);

                // Set the read/write timeouts  
                _serialport.ReadTimeout = 500;
                _serialport.WriteTimeout = 500;
                if (_serialport != null && !_serialport.IsOpen)
                {
                    Console.WriteLine("Comport is open....");
                    _serialport.Open();
                    _continue = true;

                    Console.WriteLine("Wait data....");

                    List<byte> bytes = new List<byte>();

                    string  datafordevice = "รอข้อมูลจากเครื่องวัด";
                    metroTxt_status.Text = datafordevice;                 
                    metroTxt_status.BackColor = Color.Yellow;
                    metroTxt_status.ForeColor = Color.Black;
                    metroTxt_status.Font = new Font("Arial", 35, FontStyle.Bold);

                    while (_continue)
                    {
                        bytes.Clear();

                        while (true)
                        {

                            if (_serialport.BytesToRead == 0) continue;

                            int b = _serialport.ReadByte();    //dec

                            if (b < 0) continue;
                            bytes.Add((byte)b);

                            if (bytes.Count == 59)
                            {
                                //sys
                                char sys_s = Convert.ToChar(bytes[41]);
                                char sys_y = Convert.ToChar(bytes[42]);
                                char sys_ss = Convert.ToChar(bytes[43]);
                                //map
                                char map_m = Convert.ToChar(bytes[49]);
                                char map_a = Convert.ToChar(bytes[50]);
                                char map_p = Convert.ToChar(bytes[51]);
                                //dia
                                char dia_d = Convert.ToChar(bytes[45]);
                                char dia_i = Convert.ToChar(bytes[46]);
                                char dia_a = Convert.ToChar(bytes[47]);
                                //pr
                                char pr_p = Convert.ToChar(bytes[53]);
                                char pr_r = Convert.ToChar(bytes[54]);
                                char pr_pr = Convert.ToChar(bytes[55]);
                                //datetime
                                char day_1 = Convert.ToChar(bytes[32]);
                                char day_2 = Convert.ToChar(bytes[33]);
                                //month
                                char month_1 = Convert.ToChar(bytes[29]);
                                char month_2 = Convert.ToChar(bytes[30]);


                                //year  format 2020/05/29
                                char year_1 = Convert.ToChar(bytes[24]);
                                char year_2 = Convert.ToChar(bytes[25]);
                                char year_3 = Convert.ToChar(bytes[26]);
                                char year_4 = Convert.ToChar(bytes[27]);
                                char year_5 = Convert.ToChar(bytes[28]);
                                char year_6 = Convert.ToChar(bytes[29]);
                                char year_7 = Convert.ToChar(bytes[30]);
                                char year_8 = Convert.ToChar(bytes[31]);
                                char year_9 = Convert.ToChar(bytes[32]);
                                char year_10 = Convert.ToChar(bytes[33]);

                                //time 12:00
                                char time_1 = Convert.ToChar(bytes[35]);
                                char time_2 = Convert.ToChar(bytes[36]);
                                char time_3 = Convert.ToChar(bytes[37]);
                                char time_4 = Convert.ToChar(bytes[38]);
                                char time_5 = Convert.ToChar(bytes[39]);

                                string dateformat = year_9.ToString() + year_10.ToString() + year_8.ToString() + year_6.ToString() + year_7.ToString() + year_5.ToString() + year_1.ToString() + year_2.ToString() + year_3.ToString() + year_4.ToString();
                                //houre minute
                           
                                string sys = sys_s.ToString() + sys_y.ToString() + sys_ss.ToString();
                                string map = map_m.ToString() + map_a.ToString() + map_p.ToString();
                                string dia = dia_d.ToString() + dia_i.ToString() + dia_a.ToString();
                                string pr = pr_p.ToString() + pr_r.ToString() + pr_pr.ToString();

                                string timenow = time_1.ToString() + time_2.ToString() + ":" + time_3.ToString() + time_4.ToString() + time_5.ToString();

                                string datetime_now = dateformat + " " + timenow;

                                //DateTime datenow = DateTime.ParseExact(dateformat, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                                data.Sys = sys;
                                data.Map = map;
                                data.Dia = dia;
                                data.Pr = pr;
                                data.datetime = datetime_now;

                                //Console.WriteLine(map + "-" + sys + "-" + dia + "-" + pr +"--"+ datetime_now);

                                metroTxt_sys.Text = sys;
                                metroTxt_map.Text = map;
                                metroTxt_dia.Text = dia;
                                metroTxt_pr.Text = pr;
                                metroTxt_datetime.Text = datetime_now;

                                metroTxt_status.Text = "อ่านข้อมูลสำเร็จ";
                                metroTxt_status.BackColor = Color.Green;
                                metroTxt_status.ForeColor = Color.Black;
                                metroTxt_status.Font = new Font("Arial", 35, FontStyle.Bold);

                            }
                            if (bytes.Count == 59) break;
                        }


                        if (bytes.Count == 59) break;
                    }
                }
                if(personalPhoto != null)
                   {
                    while (true)
                    {
                        metroTxt_status.Text = "การวัดเสร็จสิ้น กรุณาดึงบัตรออก...";
                        metroTxt_status.BackColor = Color.Red;
                        metroTxt_status.ForeColor = Color.Black;
                        metroTxt_status.Font = new Font("Arial", 35, FontStyle.Bold);

                        try
                        {
                            cardReader = new ThaiNationalIDCardReader();  // new method
                            personalPhoto = cardReader.GetPersonalPhoto();

                            return;
                        }
                        catch
                        {
                             return;
                        }
                       
                    }
                  }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not connection serial port", ex);
             
                metroTxt_status.Text = "กรุณาเชื่อมต่อ serialport...";
                metroTxt_status.BackColor = Color.Red;
                metroTxt_status.ForeColor = Color.Black;
                metroTxt_status.Font = new Font("Arial", 35, FontStyle.Bold);

            }

        }

        //------------read smartcard reader---------------------
        public  void  ReadSmartcard( PersonalPhoto personalPhoto)
        {
       
            Refresh();

          
            string idcard = personalPhoto.CitizenID;   //Idcard
            var thai_fullname = personalPhoto.ThaiPersonalInfo;  //----------th_fullname
            string th_firstname = thai_fullname.FirstName;  //firstname
            string th_lastname = thai_fullname.LastName;  //lastname
            string th_prefix = thai_fullname.Prefix;  //prefix
            string th_midlename = thai_fullname.MiddleName;  //middle name
            var en_fullname = personalPhoto.EnglishPersonalInfo;    //--------en_fullname
            string en_firstname = en_fullname.FirstName;  //firstname
            string en_lastname = en_fullname.LastName;  //lastname
            string en_prefix = en_fullname.Prefix;  //lastname
            string en_midlename = en_fullname.MiddleName;  //middle name en

            DateTime dateofbirth = personalPhoto.DateOfBirth;

            var gender = personalPhoto.Sex;           // sex when 1 = ชาย , 2 = หญิง
            if (gender == "1")
            {
                gender = "ชาย";
            }
            else
            {
                gender = "หญิง";
            }

            var address = personalPhoto.AddressInfo;
            string houseno = address.HouseNo;         //บ้านเลขที่
            string valiageno = address.VillageNo;     //หมู่ที่
            string lane = address.Lane;              // ตรอก ซอย
            if (lane == null) { lane = "-"; }
            string road = address.Road;              //ถนน
            if (road == null) { lane = "-"; }
            string subdistrat = address.SubDistrict; //ตำบล
            string district = address.District;      //อำเภอ
            string province = address.Province;      //จังหวัด

            DateTime issuedate = personalPhoto.IssueDate;     //วันออกบัตร
            DateTime expire = personalPhoto.ExpireDate;       //วันหมดอายุ
            string issure = personalPhoto.Issuer;    //สถานที่ออกบัตร

            var photo = personalPhoto.Photo;   //photo

            patient.IDCard = idcard;
            patient.Th_prefix = th_prefix;
            patient.Th_firstname = th_firstname;
            patient.Th_lastname = th_lastname;
            patient.Th_midlename = th_midlename;

            patient.En_prefix = en_prefix;
            patient.En_firstname = en_firstname;
            patient.En_lastname = en_lastname;
            patient.En_midlename = en_midlename;
            patient.DateOfbrith = dateofbirth;
            patient.Gender = gender;
            //address
            patient.Houseno = houseno;
            patient.Valaigeno = valiageno;
            patient.Lane = lane;
            patient.Road = road;
            patient.Subdistrict = subdistrat;
            patient.District = district;
            patient.Province = province;
            //  patient.DateOfbrith = dateofbirth;
            patient.Issure = issure;  //สถานที่ออกบัตร

            patient.Issuedate = issuedate;
            patient.Expire = expire;

            string convert_dateofbrith = formatdate(dateofbirth);
            string convert_issuedate = formatdate(issuedate);
            string convert_expire = formatdate(expire);

            metroTxt_idcard.Text = patient.IDCard;
            metroTxt_prefix_th.Text = patient.Th_prefix;
            metroTxt_firstname_th.Text = patient.Th_firstname;
            metroTxt_lastname_th.Text = patient.Th_lastname;

            metroTxt_prefix_en.Text = patient.En_prefix;
            metroTxt_firstname_en.Text = patient.En_firstname;
            metroTxt_lastname_en.Text = patient.En_lastname;

            metroTxt_dateOfbirth.Text = convert_dateofbrith;
            metroTxt_gender.Text = patient.Gender;
            metroTxt_houseno.Text = patient.Houseno;
            metroTxt_moo.Text = patient.Valaigeno;
            metroTxt_lane.Text = patient.Lane;
            metroTxt_road.Text = patient.Road;
            metroTxt_subdistrat.Text = patient.Subdistrict;
            metroTxt_distrat.Text = patient.District;
            metroTxt_province.Text = patient.Province;

            metroTxt_issuedate.Text = convert_issuedate;
            metroTxt_issure.Text = patient.Issure;
            metroTxt_expire.Text = convert_expire;

            Console.WriteLine(data.Sys);
            Console.WriteLine(data.Dia);
            Console.WriteLine(data.Map);
            Console.WriteLine(data.Pr);

            metroTxt_status.BackColor = Color.Yellow;
            metroTxt_status.ForeColor = Color.Black;
            metroTxt_status.Font = new Font("Arial", 35, FontStyle.Bold);
            metroTxt_status.Text = "อ่านข้อมูลจาก smartcard สำเร็จ";


        }

        //format datetime
        public string formatdate(DateTime date)
        {
            string date_format = date.ToString("dd/MM/yyyy", new CultureInfo("th-TH"));
            return date_format;

        }

        //clear data
        public  void Cleardata()
        {
           
            metroTxt_idcard.Text = "";
            metroTxt_prefix_th.Text = "";
            metroTxt_firstname_th.Text = "";
            metroTxt_lastname_th.Text = "";
            metroTxt_prefix_en.Text = "";
            metroTxt_firstname_en.Text = "";
            metroTxt_lastname_en.Text = "";
            metroTxt_dateOfbirth.Text = "";
            metroTxt_gender.Text = "";
            metroTxt_houseno.Text = "";
            metroTxt_moo.Text = "";
            metroTxt_lane.Text = "";
            metroTxt_road.Text = "";
            metroTxt_subdistrat.Text = "";
            metroTxt_distrat.Text = "";
            metroTxt_province.Text = "";
            metroTxt_issuedate.Text = "";
            metroTxt_issure.Text = "";
            metroTxt_expire.Text = "";
        }

    }
}
