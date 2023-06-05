using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gogo_v0._3.Administretor
{
    public partial class Marlogs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                rpt.DataSource = B_Customer.GetAll();
                rpt.DataBind();
            }
        }
    }
}