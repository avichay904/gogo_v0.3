using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace gogo_v0._3.Administretor
{
    public partial class CreateRoute : System.Web.UI.Page
    {
        protected   void Page_Load(object sender, EventArgs e)
        {
            
            string Sid=Request["Sid"];

            
            Sid = Sid.TrimEnd(',');

            List<B_Shipment> Lst = B_Shipment.GetById(Sid);
            rpt.DataSource = Lst;
            rpt.DataBind();
            

            Repiter.DataSource = BLL.B_Driver.GetAll();
            Repiter.DataBind();












        }

 

        protected async void creatRout_Click(object sender, EventArgs e)
        {
            string Sid = Request["Sid"];
            Sid = Sid.TrimEnd(',');
            List<B_Shipment> Lst = B_Shipment.GetById(Sid);

            
        


            string AppKey = "AIzaSyA3rNYnv8Z04fskn_1twWn8qO5Jqs4WBSY";
            string BaseUrl = "https://maps.googleapis.com/maps/api/directions/json?";
            string WayPoints = "";          
            string OriginUrl = "";
            string DestUrl = dataEnd.Value+"";



            for(int i = 0; i < Lst.Count; i++)
            {
                string address = Lst[i].S_city + " " + Lst[i].S_street + Lst[i].S_numeH + " " + ",+ישראל|";

                WayPoints += address;
            }

      






        }
    }
}