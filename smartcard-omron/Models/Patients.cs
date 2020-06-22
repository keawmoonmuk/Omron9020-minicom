using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartcard_omron.Models
{
  public  class Patients
    {


        public static string IDCard { get; set; }
        public static string Th_prefix { get; set; }
        public static string Th_firstname { get; set; }
        public static string Th_lastname { get; set; }
        public static string Th_midlename { get; set; }
        public static string En_prefix { get; set; }
        public static string En_firstname { get; set; }
        public static string En_lastname { get; set; }
        public static string En_midlename { get; set; }
        public static string DateOfbrith { get; set; }
        public static string Gender { get; set; }
        public static string Houseno { get; set; }
        public static string Valaigeno { get; set; }
        public static string Lane { get; set; }
        public static string Road { get; set; }
        public static string Subdistrict { get; set; }
        public static string District { get; set; }
        public static string Province { get; set; }
        public static string Issuedate { get; set; }
        public static string Expire { get; set; }  // วันหมดอายุ
        public static string Issure { get; set; }  //สถานที่ออกบัตร


    }
}
