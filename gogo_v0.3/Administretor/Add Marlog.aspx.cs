using BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;


namespace gogo_v0._3.Administretor
{
    public partial class AddMarlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string Sid = Request["Sid"] + "";
                string op = Request["op"] + "";
                if (op == "del")
                {

                    B_Customer.DeleteById(Sid);
                    Response.Redirect("Marlogs.aspx");
                }
                if (op == "edit")
                {

                    B_Customer Tmp = new B_Customer() { C_id=int.Parse(Sid)};
                    Tmp = Tmp.GetById(Tmp);
                    email.Value = Tmp.C_email;
                    phone.Value = Tmp.C_phone;
                    name.Value = Tmp.C_name;
                    city.Value = Tmp.C_city;
                    street.Value = Tmp.C_street;
                    city.Value = Tmp.C_city;
                    
                }

            }


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            string Cid = Request["Did"] + "";
            if (Cid == "")
                Cid = "-1";

            B_Customer Tmp = new B_Customer()
            {
                C_id =int.Parse(Cid),
                C_name = name.Value,
                C_city = city.Value,
                C_email = email.Value,
                C_phone = phone.Value,
                C_street = street.Value,
                C_nHome = nHome.Value,
            };

            Tmp.addCustomer(Tmp);
            Response.Redirect("Marlogs.aspx");

        }
    }
}