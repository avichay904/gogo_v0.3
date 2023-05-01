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






        public static void AddUpdate(B_Driver Tmp)
        {

            string SQL = "";
            if (Tmp.D_id == -1)
            {
                SQL = $"INSERT INTO T_Drivers (D_name,D_phone,D_address,D_email) Values ('{Tmp.D_name}','{Tmp.D_phone}','{Tmp.D_address}','{Tmp.D_email}' )";

            }
            else
            {

                SQL = $"UPDATE T_Drivers SET D_name='{Tmp.D_name}',D_phone='{Tmp.D_phone}' ,D_address='{Tmp.D_address}',D_email='{Tmp.D_email}' WHERE D_id={Tmp.D_id} ";

            }


            DBcontext Db = new DBcontext();
            Db.ExcuteNonQury(SQL);

            Db.Close();


        }


        public static void Delete(string Tmp)
        {
            string Sql = $"DELETE FROM T_Drivers WHERE D_id={Tmp} ";

            DBcontext Db = new DBcontext();
            Db.ExcuteNonQury(Sql);



        }




        public static B_Driver GetById(B_Driver Tmp)
        {
            string Sql = $"SELECT * FROM T_Drivers WHERE D_id={Tmp.D_id}"+"";



            DBcontext Db = new DBcontext();
            DataTable Dt = new DataTable();
            Dt = Db.Excute(Sql);
            Db.Close();

            for (int i = 0; i < Dt.Rows.Count; i++)
            {

                Tmp.D_id = int.Parse(Dt.Rows[i]["D_id"] + "");
                Tmp.D_name = Dt.Rows[i]["D_name"] + "";
                Tmp.D_phone = Dt.Rows[i]["D_phone"] + "";
                Tmp.D_address = Dt.Rows[i]["D_address"] + "";
                Tmp.D_email = Dt.Rows[i]["D_email"] + "";


            }
            



                return Tmp;

        }


    }
}