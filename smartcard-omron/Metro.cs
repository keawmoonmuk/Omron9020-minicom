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
using System.Net;
using System.IO;

namespace smartcard_omron
{
    public partial class Metro : MetroFramework.Forms.MetroForm
    {
        private static ThaiNationalIDCardReader cardReader;
        private static PersonalPhoto personalPhoto;

        //static bool _continue;
        //static SerialPort _serialport;
        //log      
        private string msg = "";
        private string error = "";
        string directory_root = @"C:\LOG";

        private int i = 0;

        public Metro()
        {
            InitializeComponent();

            timer_checksmartcard.Start();

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

                    if (i == 1) return;
                    if (personalPhoto.CitizenID == Patients.IDCard)
                    {

                        Readdata_result();

                        //call api

                        return;
                    }              
                }
                catch
                {
                    msg = "when not insert smart card return to Insertsmart Defualt";
                    
                    InsertSmartCard forminsertsmart = new InsertSmartCard();
                    forminsertsmart.Show();
                    timer_checksmartcard.Stop();
                   
                }

                break;

            }
        }

        //-------------form result all-----------------------
        private void Readdata_result()
        {
            i++;

            Refresh();
            string datetimenow = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            //data smartcard all
            metroTxt_idcard.Text = Patients.IDCard;
            metroTxt_prefix_th.Text = Patients.Th_prefix;
            metroTxt_firstname_th.Text = Patients.Th_firstname;
            metroTxt_lastname_th.Text = Patients.Th_lastname;
            metroTxt_prefix_en.Text = Patients.En_prefix;
            metroTxt_firstname_en.Text = Patients.En_firstname;
            metroTxt_lastname_en.Text = Patients.En_lastname;
            metroTxt_dateOfbirth.Text = Patients.DateOfbrith;
            metroTxt_gender.Text = Patients.Gender;
            metroTxt_houseno.Text = Patients.Houseno;
            metroTxt_moo.Text = Patients.Valaigeno;
            metroTxt_lane.Text = Patients.Lane;
            metroTxt_road.Text = Patients.Road;
            metroTxt_subdistrat.Text = Patients.Subdistrict;
            metroTxt_distrat.Text = Patients.District;
            metroTxt_province.Text = Patients.Province;
            metroTxt_issuedate.Text = Patients.Issuedate;
            metroTxt_issure.Text = Patients.Issure;
            metroTxt_expire.Text = Patients.Expire;

            //data device 
            metroTxt_sys.Text = Data.Sys;
            metroTxt_dia.Text = Data.Dia;
            metroTxt_pr.Text = Data.Pr;
      
            metroTxt_datetime.Text = Data.Datetime;

            metroTxt_status.Text = "การวัดเสร็จสิ้น กรุณาดึงบัตรประชาชนออก";
            metroTxt_status.BackColor = Color.GreenYellow;
            metroTxt_status.ForeColor = Color.Black;
            metroTxt_status.Font = new Font("Arial", 62, FontStyle.Bold);

            msg = "Read data to form result suecess ...";
            LogMessage();

        }

        //--------------cal api-----------------
        public void Callwebservice()
        {
            string urlapi = "https://localhost:44398/api/DataPatient";                        //url
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(urlapi);
            httpWebRequest.ContentType = "application/json";                                 //herder
            httpWebRequest.Method = "POST";                                                  //method post

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"IDCard\" :" + Patients.IDCard + "," +
                               "{\"Th_prefix\" :" + Patients.Th_prefix + "," +
                               "{\"Th_firstname\" :" + Patients.Th_firstname + "," +
                               "{\"Th_lastname\" :" + Patients.Th_lastname + "," +
                               "{\"En_prefix\" :" + Patients.En_prefix + "," +
                               "{\"En_firstname\" :" + Patients.En_firstname + "," +
                               "{\"En_lastname\" :" + Patients.En_lastname + "," +
                               "{\"DateOfbrith\" :" + Patients.DateOfbrith + "," +
                               "{\"Gender\" :" + Patients.Gender + "," +
                               "{\"Houseno\" :" + Patients.Houseno + "," +
                               "{\"Valaigeno\" :" + Patients.Valaigeno + "," +
                               "{\"Lane\" :" + Patients.Lane + "," +
                               "{\"Road\" :" + Patients.Road + "," +
                               "{\"Subdistrict\" :" + Patients.Subdistrict + "," +
                               "{\"District\" :" + Patients.District + "," +
                               "{\"Province\" :" + Patients.Province + "," +
                               "{\"Issuedate\" :" + Patients.Issuedate + "," +
                               "{\"Issure\" :" + Patients.Issure + "," +
                               "{\"Expire\" :" + Patients.Expire + "," +
                               "{\"Sys\" :" + Data.Sys + "," +
                               "{\"Dia\" :" + Data.Dia + "," +
                               "{\"Pr\" :" + Data.Pr + "," +                          
                               "{\"datetime\" :" + Data.Datetime + "," +

                                "}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();

            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }
        }

        //log complete
        public void LogMessage()
        {

            if (!Directory.Exists(directory_root))
            {
                Directory.CreateDirectory(directory_root);

            }

            StreamWriter stw = new StreamWriter(@"C:\Log\log.txt", true);
            stw.WriteLine($"TIME COMPLETE : {DateTime.Now}  MESSAGE : {msg} -- Data Patient : {Patients.Th_firstname} - {Patients.Th_lastname}, {Patients.IDCard} {Patients.Gender} {Patients.DateOfbrith} DATA BP-9020 {Data.Sys}-{Data.Dia}- {Data.Map}- {Data.Pr} ");
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
