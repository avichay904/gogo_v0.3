using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gogo_v0._3.api.v1;
using RestSharp;
using RestSharp.Authenticators;

namespace gogo_v0._3
{
    public partial class test : System.Web.UI.Page
    {
        protected async Task Page_LoadAsync(object sender, EventArgs e)
        {
            string aa = "הרצל+18+אשדוד,+ישראל|דם+המכבים+22+יבנה,+ישראל|דיזינגוף+202+תל+אביב,+ישראל|הרצל+10+נתניה,+ישראל|הרצל+40+חיפה,+ישראל";
            string st = "https://maps.googleapis.com/maps/api/directions/json?origin=הגורן+3+מטולה,+ישראל&destination=אילות+8+אילת,+ישראל&waypoints=הראשונים+26+חדרה,+ישראל|הרצל+10+תל+אביב,+ישראל|הרצל+10+באר+שבע,+ישראל&key=AIzaSyA3rNYnv8Z04fskn_1twWn8qO5Jqs4WBSY";
            string BaseUrl = "https://maps.googleapis.com/maps/api/directions/json?";
            string OriginUrl = "הגורן+3+מטולה,+ישראל";
            string DestUrl = "אילות+8+אילת,+ישראל";
            string WayPoints = "";
            string AppKey = "AIzaSyA3rNYnv8Z04fskn_1twWn8qO5Jqs4WBSY";
            string[] Address = new string[5];
            Address[0] = "הרצל 40 אשדוד";
            Address[1] = "הרצל 3 חיפה";
            Address[2] = "דיזינגוף 202 תל אביב";
            Address[3] = "הרצל 10 נתניה";
            Address[4] = "הרצל 18 אשדוד";
            //string Tmp = "הראשונים+26+חדרה,+ישראל|";
            //string str = "aa  bb cc";
            /// str.Split(' '); ["aa",""];
            for (int i = 0; i < Address.Length; i++)
            {
                string[] Arr = Address[i].Split(' ');
                string point = "";
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (Arr[j].Trim() != "")
                    {
                        point += Arr[j].Trim() + "+";
                    }
                }
                point = point.Substring(0, point.Length - 1) + ",+ישראל|";
                WayPoints += point;

            }
            WayPoints = WayPoints.Substring(0, WayPoints.Length - 1);
            string QueryUrl = $"{BaseUrl}origin={OriginUrl}&destination={DestUrl}&waypoints=optimize:true|{WayPoints}&key={AppKey}&waypoiny";
            string ans = "1,3,2,0,4";

            string test = "https://maps.googleapis.com/maps/api/directions/json?origin=הגורן+3+מטולה,+ישראל&destination=אילות+8+אילת,+ישראל&waypoints=optimize:true|הרצל+40+אשדוד,+ישראל|הרצל+3+חיפה,+ישראל|דיזינגוף+202+תל+אביב,+ישראל|הרצל+10+נתניה,+ישראל|הרצל+18+אשדוד,+ישראל&key=AIzaSyAdb8PCEpJNc-q-ojME4uQRdOEV-Kp2UkU&waypoiny" + "";






            using (var client = new WebClient())
            {
                var response = client.DownloadString("https://maps.googleapis.com/maps/api/directions/json?origin=הגורן+3+מטולה,+ישראל&destination=אילות+8+אילת,+ישראל&waypoints=optimize:true|הרצל+40+אשדוד,+ישראל|הרצל+3+חיפה,+ישראל|דיזינגוף+202+תל+אביב,+ישראל|הרצל+10+נתניה,+ישראל|הרצל+18+אשדוד,+ישראל&key=YOUR_API_KEY_HERE&waypoints");
                Response.Write(response);
            }





        }



    }
    
}