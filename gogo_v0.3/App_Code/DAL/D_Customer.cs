using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class D_Customer
    {

        public static List<B_Customer> GetAll()
        {
            List<B_Customer> lst= new List<B_Customer>();
            string Sql=$"SELECT * FROM T_Customer";

            DBcontext Db=new DBcontext();
            DataTable Dt=new DataTable();
            Dt=Db.Excute(Sql);

            for(int i = 0; i < Dt.Rows.Count; i++)
            {
                B_Customer Tmp = new B_Customer()
                {
                    C_id = int.Parse(Dt.Rows[i]["C_id"] + ""),
                    C_name = Dt.Rows[i]["C_name"] + "",
                    C_phone = Dt.Rows[i]["C_phone"] + "",
                    C_email = Dt.Rows[i]["C_email"] + "",
                    C_city = Dt.Rows[i]["C_city"] + "",
                    C_street = Dt.Rows[i]["C_street"] + "",
                    C_nHome = Dt.Rows[i]["C_nHome"] + ""
                };

                lst.Add (Tmp);
    
            }


            return lst;

        }




    }
}