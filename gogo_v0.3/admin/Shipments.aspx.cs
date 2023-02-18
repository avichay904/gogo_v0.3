using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace gogo_v0._3.admin
{
    public partial class Shipments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Rpt.DataSource = B_Shipment.GetAll();
            Rpt.DataBind(); 
            

        }
    }
}