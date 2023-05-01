using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;


namespace gogo_v0._3
{
    public partial class forgot_Pass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_ForgotPass_Click(object sender, EventArgs e)
        {

            B_User Tmp = new B_User();
            Tmp.U_email = Email.Value;
           
            if(Tmp.Check_Email(Tmp))
            {

                
                string Body = $"<!doctype html>\r\n<html lang=\"en\">\r\n  <head>\r\n  \r\n  </head>\r\n  <body>\r\n   \r\n    \r\n    \r\n<a href=\"http://localhost:58179/ResetPass.aspx?Token={Tmp.U_Token}\">לשחזור הסיסמה לחץ כאן</a>\r\n\r\n\r\n\r\n\r\n\r\n\r\n   \r\n  </body>\r\n</html>";
                 

                Services.Send_Email(Tmp.U_email, "איפוס סיסמה",Body);
            
            
            }
               
      
            


        }
    }
}