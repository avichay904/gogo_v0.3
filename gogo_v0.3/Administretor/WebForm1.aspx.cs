using BLL;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace gogo_v0._3.Administretor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ltaWayPonit.Text = Session["waypointOrder"] + "";
                Response.Write(e.ToString()); // log


                string Origin = Session["Origin"] + "";
                string destination = Session["destination"] + "";
                string waypointOrder = Session["waypointOrder"] + "";
               


            }

        }
    }
}