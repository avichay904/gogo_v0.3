using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using BLL;


namespace DAL
{
    public class D_User
    {

        public static B_User CheckLoginDal(B_User User)
        {





            //השאילתה מחזירה רק שורה אחת
            string Sql = $"SELECT * FROM T_Users WHERE U_pass='{User.U_psss}' AND U_email='{User.U_email}'";
            DBcontext Db = new DBcontext();
            DataTable Dt = Db.Excute(Sql);

            if (Dt.Rows.Count > 0)
            {

                User.U_id = int.Parse(Dt.Rows[0]["U_id"] + "");
                User.U_psss = Dt.Rows[0]["U_pass"] + "";
                User.U_phone = Dt.Rows[0]["U_phone"] + "";
                User.U_name = Dt.Rows[0]["U_name"] + "";
                User.U_email = Dt.Rows[0]["U_title"]+"";


                Db.Close();
                return User;

            }

            Db.Close();

            return null;
                


        }

    }
    
}