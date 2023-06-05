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
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using System.IO;
using System.Threading;
using System.Text;

namespace gogo_v0._3
{
    public partial class test : System.Web.UI.Page
    {
        //protected async Task Page_LoadAsync(object sender, EventArgs e)
        //{
        //    string aa = "הרצל+18+אשדוד,+ישראל|דם+המכבים+22+יבנה,+ישראל|דיזינגוף+202+תל+אביב,+ישראל|הרצל+10+נתניה,+ישראל|הרצל+40+חיפה,+ישראל";
        //    string st = "https://maps.googleapis.com/maps/api/directions/json?origin=הגורן+3+מטולה,+ישראל&destination=אילות+8+אילת,+ישראל&waypoints=הראשונים+26+חדרה,+ישראל|הרצל+10+תל+אביב,+ישראל|הרצל+10+באר+שבע,+ישראל&key=AIzaSyA3rNYnv8Z04fskn_1twWn8qO5Jqs4WBSY";
        //    string BaseUrl = "https://maps.googleapis.com/maps/api/directions/json?";
        //    string OriginUrl = "הגורן+3+מטולה,+ישראל";
        //    string DestUrl = "אילות+8+אילת,+ישראל";
        //    string WayPoints = "";
        //    string AppKey = "AIzaSyA3rNYnv8Z04fskn_1twWn8qO5Jqs4WBSY";
        //    string[] Address = new string[5];
        //    Address[0] = "הרצל 40 אשדוד";
        //    Address[1] = "הרצל 3 חיפה";
        //    Address[2] = "דיזינגוף 202 תל אביב";
        //    Address[3] = "הרצל 10 נתניה";
        //    Address[4] = "הרצל 18 אשדוד";
        //    //string Tmp = "הראשונים+26+חדרה,+ישראל|";
        //    //string str = "aa  bb cc";
        //    /// str.Split(' '); ["aa",""];
        //    for (int i = 0; i < Address.Length; i++)
        //    {
        //        string[] Arr = Address[i].Split(' ');
        //        string point = "";
        //        for (int j = 0; j < Arr.Length; j++)
        //        {
        //            if (Arr[j].Trim() != "")
        //            {
        //                point += Arr[j].Trim() + "+";
        //            }
        //        }
        //        point = point.Substring(0, point.Length - 1) + ",+ישראל|";
        //        WayPoints += point;

        //    }
        //    WayPoints = WayPoints.Substring(0, WayPoints.Length - 1);
        //    string QueryUrl = $"{BaseUrl}origin={OriginUrl}&destination={DestUrl}&waypoints=optimize:true|{WayPoints}&key={AppKey}&waypoiny";
        //    string ans = "1,3,2,0,4";

        //    string test = "https://maps.googleapis.com/maps/api/directions/json?origin=הגורן+3+מטולה,+ישראל&destination=אילות+8+אילת,+ישראל&waypoints=optimize:true|הרצל+40+אשדוד,+ישראל|הרצל+3+חיפה,+ישראל|דיזינגוף+202+תל+אביב,+ישראל|הרצל+10+נתניה,+ישראל|הרצל+18+אשדוד,+ישראל&key=AIzaSyAdb8PCEpJNc-q-ojME4uQRdOEV-Kp2UkU&waypoiny" + "";






        //    using (var client = new WebClient())
        //    {
        //        var response = client.DownloadString("https://maps.googleapis.com/maps/api/directions/json?origin=הגורן+3+מטולה,+ישראל&destination=אילות+8+אילת,+ישראל&waypoints=optimize:true|הרצל+40+אשדוד,+ישראל|הרצל+3+חיפה,+ישראל|דיזינגוף+202+תל+אביב,+ישראל|הרצל+10+נתניה,+ישראל|הרצל+18+אשדוד,+ישראל&key=YOUR_API_KEY_HERE&waypoints");
        //        Response.Write(response);
        //    }


        public static void SendEmail(string recipient, string subject, string body)
        {
            // קובע את התצורה של כתובת ה-credential שקיבלתם מ-Google Cloud Console
            GoogleCredential credential;
            using (var stream = new FileStream("path_to_credentials.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(GmailService.Scope.GmailCompose);
            }

            // איתחול של ה- GmailService
            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GOGO DRIVER",
            });

            // בניית הגוף של המייל
            var email = new Google.Apis.Gmail.v1.Data.Message()
            {
                Raw = Base64UrlEncode(GenerateEmailBody(recipient, subject, body)),
            };

            // שליחת המייל
            service.Users.Messages.Send(email, "me").Execute();
        }

        // המרה של מחרוזת בפורמט Base64Url
        private static string Base64UrlEncode(string input)
        {
            var inputBytes = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(inputBytes)
                .Replace('+', '-')
                .Replace('/', '_')
                .Replace("=", "");
        }

        // יצירת גוף המייל כפי שנדרש על ידי ה-API
        private static string GenerateEmailBody(string recipient, string subject, string body)
        {
            var email = new StringBuilder();
            email.AppendLine("From: Your Name <your_email@gmail.com>");
            email.AppendLine("To: " + recipient);
            email.AppendLine("Subject: " + subject);
            email.AppendLine("Content-Type: text/plain; charset=utf-8");
            email.AppendLine();
            email.AppendLine(body);

            return email.ToString();
        }






















        public test() { }


        }



    }
    

