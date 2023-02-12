using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace gogo_v0._3
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void Btn_Register_Click(object sender, EventArgs e)
        {



            B_User Tmp = new B_User()
            {

                U_name = Name.Value,
                U_email = Email.Value,
                U_phone= phone.Value,
                U_psss=Pass.Value,


                
            };
            if (Tmp.Check_Register(Tmp) && Pass.Value == Pass2.Value)
            {

                Response.Redirect("/admin/Home.aspx");
            
            }
            else 
               ClientScript.RegisterClientScriptBlock(this.GetType(),"alert","פרטי ההרשמה אינם נכונים",true);


               
          
               



               





         }





        }




}