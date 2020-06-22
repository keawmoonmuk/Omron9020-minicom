using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartcard_omron.Models
{
  public  class Patients
    {

        public string IDCard { get; set; }
        public string Th_prefix { get; set; }
        public string Th_firstname { get; set; }
        public string Th_lastname { get; set; }
        public string Th_midlename { get; set; }

        public string En_prefix { get; set; }
        public string En_firstname { get; set; }
        public string En_lastname { get; set; }
        public string En_midlename { get; set; }

        public DateTime DateOfbrith { get; set; }
        public string Gender { get; set; }
        public string Houseno { get; set; }   
        public string Valaigeno { get; set; }  
        public string Lane { get; set; }  
        public string Road { get; set; }
        public string Subdistrict { get; set; }
        public string District { get; set; }  
        public string Province { get; set; }  
                                             
        public DateTime Issuedate { get; set; } 
                                                 
        public DateTime Expire { get; set; }  // วันหมดอายุ
        public string Issure { get; set; }  //สถานที่ออกบัตร


    }
}
