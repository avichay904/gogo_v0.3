using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class B_Customer
    {
        public int C_id { get; set; }
        public string C_name { get; set;}
        public string C_phone { get; set;}
        public string C_email { get ; set;}
        public string C_city { get;set;}
        public string C_street { get; set;}
        public string C_nHome{ get; set;}

        
        public static List<B_Customer> GetAll()
        {
            return D_Customer.GetAll();
        }
    }
}