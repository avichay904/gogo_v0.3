using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gogo_v0._3.Administretor
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


                rpt.DataSource = B_Shipment.GetAll();

                rpt.DataBind();


                // _______________________________________________________________כאן אני סוכם את כול הנתונים כדי להציג דוח _______________
                List<B_Driver> Driver = B_Driver.GetAll();
                
               int cnt= Driver.Count;

                Session["cnt_Driver"]=cnt;



                int cnt_marlog = B_Customer.GetAll().Count ;

                Session["cnt_marlog"] = cnt_marlog;

                
               List<B_Shipment> Shipments= B_Shipment.GetAll();

                int cnt_Shipment= Shipments.Count();
                    
                   

                Session["cnt_Shipment"] = cnt_Shipment;

                B_Shipment lastShipment1 = Shipments[cnt_Shipment-1];
                int lest_Id = lastShipment1.S_id;


                Session["lest_Id"] = lest_Id;



            }




       
        }

        protected void rpt_Init(object sender, EventArgs e)
        {

        }

        protected void rpt_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

        }
    }
}