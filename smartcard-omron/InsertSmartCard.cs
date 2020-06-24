using smartcard_omron.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiNationalIDCard.NET;
using ThaiNationalIDCard.NET.Models;
using System.IO;

namespace smartcard_omron
{
    public partial class InsertSmartCard : Form
    {
        //import libraly thaination idcard
        public static ThaiNationalIDCardReader cardReader;
        public static PersonalPhoto personalPhoto;

        //log      
        private string msg = "";
        private string error = "";
        string directory_root = @"C:\LOG";

        public InsertSmartCard()
        {
            InitializeComponent();

            //start timer 
            timer_checkReadsmartcard.Start();

           
        }

        //timer read smartcard
        private void timer_checkReadsmartcard_Tick(object sender, EventArgs e)
        
        {
            while (true)
            {
                try
                {
                    cardReader = null;
                    personalPhoto = null;
                    cardReader = new ThaiNationalIDCardReader();
                    personalPhoto = cardReader.GetPersonalPhoto();

                    if(personalPhoto.CitizenID == Patients.IDCard)
                    {
                        ReadOmron9020 formreaddata_bp9020 = new ReadOmron9020();

                        this.Hide();
                        formreaddata_bp9020.Show();

                        timer_checkReadsmartcard.Stop();

                        return;
                    }

                    Readsmartcard(personalPhoto);
                    msg = " Read smartcard suecess ....";
                    LogMessage();  //log file
                }
                catch(Exception ex)
                {
                    error = "Id card not inserted ";
                  
                    LogMessageError();

                    Console.WriteLine("Not insert smartcard reader...", ex);
                }
            }
        }

        //read smartcard
        private void Readsmartcard(PersonalPhoto personalPhoto)
        {
            Refresh();
            string idcard = personalPhoto.CitizenID;  
            var thai_fullname = personalPhoto.ThaiPersonalInfo; 
            string th_firstname = thai_fullname.FirstName; 
            string th_lastname = thai_fullname.LastName; 
            string th_prefix = thai_fullname.Prefix; 
            string th_midlename = thai_fullname.MiddleName; 
            var en_fullname = personalPhoto.EnglishPersonalInfo;   
            string en_firstname = en_fullname.FirstName;  
            string en_lastname = en_fullname.LastName; 
            string en_prefix = en_fullname.Prefix; 
            string en_midlename = en_fullname.MiddleName; 

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
            string lane = address.Lane;                 // ตรอก ซอย
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

            Patients.IDCard = idcard;
            Patients.Th_prefix = th_prefix;
            Patients.Th_firstname = th_firstname;
            Patients.Th_lastname = th_lastname;
            Patients.Th_midlename = th_midlename;
            Patients.En_prefix = en_prefix;
            Patients.En_firstname = en_firstname;
            Patients.En_lastname = en_lastname;
            Patients.En_midlename = en_midlename;
            Patients.Gender = gender;
            //address
            Patients.Houseno = houseno;
            Patients.Valaigeno = valiageno;
            Patients.Lane = lane;
            Patients.Road = road;
            Patients.Subdistrict = subdistrat;
            Patients.District = district;
            Patients.Province = province;
            //  patient.DateOfbrith = dateofbirth;
            Patients.Issure = issure;  //สถานที่ออกบัตร

            string convert_dateofbrith = Formatdate(dateofbirth);
            string convert_issuedate = Formatdate(issuedate);
            string convert_expire = Formatdate(expire);

            Patients.DateOfbrith = convert_dateofbrith;
            Patients.Issuedate = convert_issuedate;
            Patients.Expire = convert_expire;

        }

        //formate date 
        private string Formatdate(DateTime date)
        {
            string date_formate = date.ToString("dd/MM/yyyy", new CultureInfo("th-TH"));
            return date_formate;
        }

        //log complete
        public void LogMessage()
        {
          
            if (!Directory.Exists(directory_root))
            {
                Directory.CreateDirectory(directory_root);

            }

            StreamWriter stw = new StreamWriter(@"C:\Log\log.txt", true);
            stw.WriteLine($"TIME COMPLETE : {DateTime.Now}-- MESSAGE : {msg} -- Data Patient : {Patients.Th_firstname} - {Patients.Th_lastname}, {Patients.IDCard} {Patients.Gender} {Patients.DateOfbrith} ");
            stw.Close();

        }

        //log error
        public void LogMessageError()
        {
            if (!Directory.Exists(directory_root))
            {
                Directory.CreateDirectory(directory_root);
            }
                StreamWriter stw = new StreamWriter(@"C:\Log\log.txt", true);
                stw.WriteLine($"TIME ERROR : {DateTime.Now}  Error Message : {error} ");
                stw.Close();            
        }

    }
}
