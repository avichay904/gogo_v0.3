using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace BLL
{
    public class B_Driver
    {
        public int D_id { get; set; }

        public string D_name { get; set; }
        public string D_phone { get; set; }
        public string D_address { get; set; }
        public string D_email { get; set; }
     

        public B_Driver() { }


        public static List<B_Driver> GetAll()
        {
            return D_Driver.GetAll();
          
        }





    }
}