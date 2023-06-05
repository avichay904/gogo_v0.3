using DAL;
using gogo_v0._3;
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

         //הוספת מרלוג
        public void addCustomer(B_Customer Customer)
        {
            D_Customer.AddUpdate(Customer);

            string Body = $"<h1>{Customer.C_name} ברוך הבא לצוות הנהגים</h1>";
          //  Services.Send_Email(Customer.C_email, "הרשמה לנהג", Body);


        }
        // מחיקה
        public static void DeleteById(string Cid)
        {
            D_Customer.Delete(Cid);

        }

        public B_Customer GetById(B_Customer Cid)
        {
            return D_Customer.GetById(Cid);
        }


    }
}