using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace gogo_v0._3.Administretor
{
    public partial class UpdataShipment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string Sid = Request["Sid"] + "";

            rpt.DataSource = BLL.B_Customer.GetAll();
            rpt.DataBind();
            Repiter.DataSource = BLL.B_Driver.GetAll();
            Repiter.DataBind();

            B_Shipment Tmp = new B_Shipment() { S_id = int.Parse(Sid) };
            Tmp.GetById(Tmp);
            street_number.Text = Tmp.S_numeH;
            route.Text = Tmp.S_street;
            locality.Text = Tmp.S_city;
            phone.Value = Tmp.S_Phone;
            numBox.Value = Tmp.S_sumBox.ToString();
            dataEnd.Value = Tmp.S_dataEnd;
            msg.Value = Tmp.S_msg;


        }

        protected void Btn_Click(object sender, EventArgs e)
        {

            B_Shipment Tmp2 = new B_Shipment()
            {
                S_id =int.Parse( Request["Sid"]),
                S_city = route.Text+"",

                S_dataEnd = dataEnd.Value+"",
                S_Phone = phone.Value+"",
                S_street = locality.Text+"",
                S_msg = msg.Value+"",
                S_numeH = street_number.Text + "",
                S_sumBox = int.Parse(numBox.Value+""),

            };

            Tmp2.addShipment(Tmp2);

        
            Response.Redirect("Shipments.aspx");
        }
    }
}