using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Google.Apis.Requests.BatchRequest;

namespace gogo_v0._3
{
    public partial class testGoogle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {


                var response = client.DownloadString("https://maps.googleapis.com/maps/api/directions/json?origin=הגורן+3+מטולה,+ישראל&destination=אילות+8+אילת,+ישראל&waypoints=optimize:true|הרצל+40+אשדוד,+ישראל|הרצל+3+חיפה,+ישראל|דיזינגוף+202+תל+אביב,+ישראל|הרצל+10+נתניה,+ישראל|הרצל+18+אשדוד,+ישראל&key=AIzaSyAdb8PCEpJNc-q-ojME4uQRdOEV-Kp2UkU&waypoiny");
                

                var parsedResponse = JObject.Parse(response);

                if (parsedResponse["status"].ToString() == "OK")
                {
                    var waypointOrder = parsedResponse["routes"][0]["waypoint_order"];

                
                }
            }
            


        }
    }
}