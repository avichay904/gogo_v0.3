using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft;
using BLL;
using System.Text;

namespace gogo_v0._3.App_Code
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {
 
        public void ProcessRequest(HttpContext context)
        {


            StringBuilder Sb= new StringBuilder();

            string dt = context.Request["dt"];// במידה קיבלנו בבקשה פרמטר?
            
            

                List<B_Shipment>lst=B_Shipment.GetAll();// שליפת גול המוצרים

                Sb.AppendLine("<TABLE>");
                foreach(B_Shipment x in lst)
                {
                    Sb.AppendLine("<tr>");
                    Sb.AppendLine($"<td> {x.S_city}</td>");
                    Sb.AppendLine($"<td> {x.D_id}</td>");
                    Sb.AppendLine($"<td> {x.S_city}</td>");
                    Sb.AppendLine($"<td> {x.S_city}</td>");
                    Sb.AppendLine("</tr>");
                }
                Sb.AppendLine("</TABLE>");




                context.Response.Write( Sb.ToString()); 
               

            
            //context-Disposition", $"attachment; filename={dt}.xls");
            context.Response.ContentType = "application/vnd.ms-excel";
            context.Response.AddHeader("Content-Disposition", $"attachment; filename={dt}.xls");
            context.Response.Write(Sb.ToString());
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}