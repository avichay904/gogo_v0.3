using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace gogo_v0._3.Administretor
{
    public partial class AddDriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
            if (!IsPostBack)
            {
                B_Driver Tmp = new B_Driver();
                string Did = Request["Did"] + "";
                string op = Request["op"] + "";
                if (op == "del")
                {

                    B_Driver.DeleteById(Did);
                    Response.Redirect("Drivers.aspx");
                }

                if (op == "edit")
                {
                      
                    Tmp= B_Driver.GetById(int.Parse(Did));                    
                    Name.Value= Tmp.D_name + "";
                    Email.Value = Tmp.D_email + "";
                  phone.Value = Tmp.D_phone + "";
                    Address.Value = Tmp.D_address + "";
                }




            }
        }

        protected void addDriver_Click(object sender, EventArgs e)
        {
            string Did = Request["Did"] + "";
            if (Did == "")
                Did ="-1";
            B_Driver Tmp = new B_Driver()
            {

                D_name = Name.Value + "",
                D_address = Address.Value + "",
                D_email = Email.Value + "",
                D_phone = phone.Value + "",
                D_id = int.Parse(Did)
            };
         
            
                Tmp.addDriver(Tmp);
            Response.Redirect("drivers.aspx");


        }

        protected void add_Click(object sender, EventArgs e)
        {

        }
    }
}