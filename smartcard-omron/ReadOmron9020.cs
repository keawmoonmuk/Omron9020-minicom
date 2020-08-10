using smartcard_omron.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smartcard_omron
{
    public partial class ReadOmron9020 : Form
    {

        public Data data = new Data();  //import Class Data
        static bool _continue;
        static SerialPort _serialport;

        //log      
        private string msg = "";
        private string error = "";
        string directory_root = @"C:\LOG";

        public ReadOmron9020()
        {
            InitializeComponent();

            timer_readOmron9020.Start();
        }

        //read data form Omron bp 9020 
        private void timer_readOmron9020_Tick(object sender, EventArgs e)
        {
            if (Data.Sys == null)
            {
                string idc = Patients.IDCard;
                Console.WriteLine(idc);
                ReaddataOmron9020();

            }
            else
            {
                Metro formresult = new Metro();

                this.Hide();
                formresult.Show();

                timer_readOmron9020.Stop();
            }

        }

        private void ReaddataOmron9020()
        {
            try
            {
                //connect serial port  
                _serialport = new SerialPort();
                _serialport = new SerialPort("COM2", 2400, Parity.Even, 8, StopBits.One);

                // Set the read/write timeouts  
                _serialport.ReadTimeout = 500;
                _serialport.WriteTimeout = 500;
                if (_serialport != null && !_serialport.IsOpen)
                {
                    Console.WriteLine("Comport is open....");
                    _serialport.Open();
                    _continue = true;

                    Console.WriteLine("Wait data....");
                    msg = "Wait data form inbody 320.....";
                    LogMessage();
                    List<byte> bytes = new List<byte>();

                    while (_continue)
                    {
                        bytes.Clear();


                        while (true)
                        {

                            if (_serialport.BytesToRead == 0) continue;

                            int b = _serialport.ReadByte();    //dec

                            if (b < 0) continue;
                            bytes.Add((byte)b);

                            if (bytes.Count == 58 ||  bytes.Count == 59)
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

                                string timenow = time_1.ToString() + time_2.ToString() + time_3.ToString() + time_4.ToString() + time_5.ToString();

                                string datetime_now = dateformat + " " + timenow;

                                Data.Sys = sys;
                                Data.Map = map;
                                Data.Dia = dia;
                                Data.Pr = pr;
                                Data.Datetime = datetime_now;

                                msg = "Read data form serialport suecess...";
                                LogMessage();
                            }
                            if (bytes.Count == 58 || bytes.Count == 59) break;
                        }


                        if (bytes.Count ==58 || bytes.Count == 59) break;
                    }
                }

            }
            catch (Exception ex)
            {
                error = "Not connect Serialport.... ";
                LogMessageError();
                Console.WriteLine("Not connection serial port", ex);

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
            stw.WriteLine($"TIME COMPLETE : {DateTime.Now} MESSAGE : {msg} -- Data Patient : {Patients.Th_firstname} - {Patients.Th_lastname}, {Patients.IDCard} {Patients.Gender} {Patients.DateOfbrith} DATA BP-9020 {Data.Sys}-{Data.Dia}- {Data.Map}- {Data.Pr} ");
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
