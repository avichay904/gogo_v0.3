﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using DAL;

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


        public B_User CheckLogin(B_User user) 
        {
           
           return D_User.CheckLoginDal(user);

        }



        public bool Check_Register(B_User person)
        {
            string Phon = person.U_phone;
            string Email = person.U_email.ToLower();
            string Pass = person.U_psss;
            int title = person.U_title;
            // בדיקות תקינות
            // 



           return D_User.checkRgister(person);
          


        }








    }

}