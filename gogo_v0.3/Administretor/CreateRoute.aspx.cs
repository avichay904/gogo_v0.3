using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace gogo_v0._3.Administretor
{
    public partial class CreateRoute : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            Repiter.DataSource = BLL.B_Driver.GetAll();
            Repiter.DataBind();

        }
    }
}