using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;  


namespace gogo_v0._3.admin
{
    public partial class Custommers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)// כאשר מדובר בטעינה ראשונית
            {
                FillData();// הפעלת הפונקציה לטעינה ראשונה של הנתונים
            }

        }

        public void FillData()
        {

            RtpCustomer.DataSource= B_Customer.GetAll();    
            RtpCustomer.DataBind();
        }

        protected void RtpCustomer_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
             
        }
    }
}