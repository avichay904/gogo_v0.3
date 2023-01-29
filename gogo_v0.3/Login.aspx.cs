using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;



namespace gogo_v0._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_login(object sender, EventArgs e)
        {

            B_User Tmp = new B_User()
            {

                U_email = Email.Text,
                U_psss = Pass.Text

            };

            if (Tmp.CheckLogin(Tmp)==null)
            {
         
                Response.Redirect("/Register");
            }
            else
            {
                Session["login"] = Tmp;
                Response.Redirect("/admin/Home.aspx");

            }




        }






    }
    
    
   
        
}