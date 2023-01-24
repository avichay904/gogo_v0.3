using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class B_User
    {
        public int U_id { get; set; }
        public string U_psss { get; set; }
        public string U_email{ get; set;}
        public int U_title { get; set;}
        public string U_name { get; set;}
        public string U_phone { get; set;}

        public B_User() { }

        public B_User(int u_id, string u_psss, string u_email, int u_title, string u_name, string u_phone)
        {
            U_id = u_id;
            U_psss = u_psss;
            U_email = u_email;
            U_title = u_title;
            U_name = u_name;
            U_phone = u_phone;
        }
    }
}