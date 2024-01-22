using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gogo_v0._3.admin
{
    public partial class Drivers : System.Web.UI.Page
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

            RtpCustomer.DataSource = B_Driver.GetAll();
            RtpCustomer.DataBind();
        }
    }
}