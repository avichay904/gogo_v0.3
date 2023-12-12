using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace gogo_v0._3.Administretor
{
    public partial class Shipments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rpt.DataSource = B_Shipment.GetAll();

                rpt.DataBind();
            
                
            }


        }

  

        protected void delete_Click(object sender, EventArgs e)
        {
            
        }

        protected void rpt_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {

            
            if (e.Item.ItemType == ListItemType.Item)
            {
                ((Literal)e.Item.FindControl("ltl_Driver")).Text = B_Driver.GetById(((B_Shipment)e.Item.DataItem).D_id).D_name;
            }
        }
    }
}