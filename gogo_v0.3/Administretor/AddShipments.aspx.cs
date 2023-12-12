using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace gogo_v0._3.Administretor
{
    public partial class AddShipments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                string Sid = Request["Sid"] + "";
                string op = Request["op"] + "";
                if (op == "del")
                {

                    B_Shipment.DeleteById(Sid);
                    Response.Redirect("Shipments.aspx");
                }






                Cname.DataSource = BLL.B_Customer.GetAll();

                Cname.DataValueField = "C_id";
                Cname.DataTextField = "C_name";
                Cname.DataBind();

                Dname.DataSource = B_Driver.GetAll();
                Dname.DataValueField = "D_id";
                Dname.DataTextField = "D_name";
                Dname.DataBind(); 


           
            }
        }

        protected void Btn_Click(object sender, EventArgs e)
        {


            B_Shipment Tmp = new B_Shipment()
            {
                S_id = -1,
                S_city = locality.Text + "",

                S_dataEnd = dataEnd.Value + ""  ,
                S_Phone = phone.Value+"",
                S_street = route.Text+"",
                S_msg = msg.Value + "",
                S_numeH = street_number.Text,      
                S_sumBox=int.Parse(numBox.Value),
                C_id=int.Parse(Cname.SelectedValue),
                D_id= int.Parse(Dname.SelectedValue),

                



            };
        
            Tmp.addShipment(Tmp);
            Response.Redirect("Shipments.aspx");

        }
    }
}