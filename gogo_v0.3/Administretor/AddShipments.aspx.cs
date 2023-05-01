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


            }



            rpt.DataSource=BLL.B_Customer.GetAll();          
            rpt.DataBind();
           Repiter.DataSource=BLL.B_Driver.GetAll();
            Repiter.DataBind(); 
        }

        protected void Btn_Click(object sender, EventArgs e)
        {


            B_Shipment Tmp = new B_Shipment()
            {
                S_id = -1,
                S_city = route.Text + "",

                S_dataEnd = dataEnd.Value + ""  ,
                S_Phone = phone.Value+"",
                S_street = locality.Text+"",
                S_msg = msg.Value + "",
                S_numeH = street_number.Text + "0",      
                S_sumBox=int.Parse(numBox.Value)+0,          
                
            };
            Response.Redirect("Shipments.aspx");
            Tmp.addShipment(Tmp);

            
        }
    }
}