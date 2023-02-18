using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace DAL
{
    public class D_Driver
    {



        public static List<B_Driver> GetAll()
        {
            List<B_Driver> lst = new List<B_Driver>();
            string Sql = $"SELECT * FROM T_Drivers";

            DBcontext Db = new DBcontext();
            DataTable Dt = new DataTable();
            Dt = Db.Excute(Sql);

            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                B_Driver Tmp = new B_Driver()
                {
                    D_id = int.Parse(Dt.Rows[i]["D_id"] + ""),
                    D_name = Dt.Rows[i]["D_name"] + "",
                    D_phone= Dt.Rows[i]["D_phone"] + "",
                    D_address= Dt.Rows[i]["D_address"] + "",
                    D_email= Dt.Rows[i]["D_email"] + ""



                };

                lst.Add(Tmp);

            }


            return lst;

        }




    }
}