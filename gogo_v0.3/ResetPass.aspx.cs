using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace gogo_v0._3
{
    public partial class ResetPass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string Token = Request["Token"];

                B_User Tmp = new B_User() { U_Token = Token };

                if (!Tmp.Chack_Token(Tmp))
                {
                    Response.Redirect("404.aspx");

                }



            }
        }

     

        protected void Btn_reset_Click(object sender, EventArgs e)
        {
            B_User Tmp = new B_User()
            {
                U_email = Email.Value,
                U_psss = Pass.Value

            };

            Tmp.resetPass(Tmp);
            Response.Redirect("Login.aspx");

        }
    }
}