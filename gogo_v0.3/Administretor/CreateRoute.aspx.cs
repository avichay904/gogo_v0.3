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

            if (Sid == null || Sid.Length < 1)
                Response.Redirect("Shipments.aspx");
            Sid = Sid.TrimEnd(',');

            if (!IsPostBack)
            {
                List<B_Shipment> Lst = B_Shipment.GetById(Sid);
                rpt.DataSource = Lst;
                rpt.DataBind();



                // חיבור לדרופדאון של המרלוג
                Cname.DataSource = BLL.B_Customer.GetAll();
                Cname.DataValueField = "C_city";
                Cname.DataTextField = "C_name";
                Cname.DataBind();

                // חיבור לדרופדאון של הנהגים
                Dname.DataSource = BLL.B_Driver.GetAll();
                Dname.DataValueField = "D_id";
                Dname.DataTextField = "D_address";
                Dname.DataBind();


            }




        }

 

        protected void creatRout_Click(object sender, EventArgs e)
        {


            string Sid = Request["Sid"];
            Sid = Sid.TrimEnd(',');
            List<B_Shipment> Lst = B_Shipment.GetById(Sid);

            
        


            string AppKey = "AIzaSyA3rNYnv8Z04fskn_1twWn8qO5Jqs4WBSY";
            string BaseUrl = "https://maps.googleapis.com/maps/api/directions/json?";
            string WayPoints = "";
            string OriginUrl = Cname.SelectedValue;
            string DestUrl = Dname.SelectedValue;


            for(int i = 0; i < Lst.Count; i++)
            {
                string address = Lst[i].S_city + " " + Lst[i].S_street + Lst[i].S_numeH + " " + ",+ישראל|";

                WayPoints += address;
            }

            WayPoints = WayPoints.Substring(0, WayPoints.Length - 1);


            string QueryUrl = $"{BaseUrl}origin={OriginUrl}&destination={DestUrl}&waypoints=optimize:true|{WayPoints}&key={AppKey}&waypoiny";



            using (var client = new WebClient())
            {
                var response = client.DownloadString(QueryUrl);
                Response.Write(response);
            }


        }
    }
}