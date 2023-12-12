using BLL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml.Linq;

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

        public static B_Customer GetById(B_Customer Tmp)
        {
            string Sql = $"SELECT * FROM T_Customer WHERE C_id={Tmp.C_id}" + "";



            DBcontext Db = new DBcontext();
            DataTable Dt = new DataTable();
            Dt = Db.Excute(Sql);
            Db.Close();
            for (int i = 0; i < Dt.Rows.Count; i++)
            {

                Tmp.C_id = int.Parse(Dt.Rows[i]["C_id"] + "");
                Tmp.C_name = Dt.Rows[i]["C_name"] + "";
                Tmp.C_phone = Dt.Rows[i]["C_phone"] + "";
                Tmp.C_email = Dt.Rows[i]["C_email"] + "";
                Tmp.C_city = Dt.Rows[i]["C_city"] + "";
                Tmp.C_street = Dt.Rows[i]["C_street"] + "";
                Tmp.C_nHome = Dt.Rows[i]["C_nHome"] + "";


            }




            return Tmp;


        }


       public static void AddUpdate(B_Customer Tmp)
        {

            string SQL = "";
            if (Tmp.C_id == -1)
            {
                SQL = $"INSERT INTO T_Customer (C_name,C_phone,C_city,C_street,C_nHome,C_email) Values (N'{Tmp.C_name}',N'{Tmp.C_phone}',N'{Tmp.C_city}',N'{Tmp.C_street} ',N'{Tmp.C_nHome}','{Tmp.C_email}' )";

            }
            else
            {

                SQL = $"UPDATE T_Customer SET C_name=N'{Tmp.C_name}',C_phone=N'{Tmp.C_phone}' ,C_city=N'{Tmp.C_city}',C_street=N'{Tmp.C_street}' ,C_nHome=N'{Tmp.C_nHome}' ,C_email='{Tmp.C_email}' WHERE C_id={Tmp.C_id} ";

            }


            DBcontext Db = new DBcontext();
            Db.ExcuteNonQury(SQL);

            Db.Close();


        }





        public static void Delete(string Tmp)
        {
            string Sql = $"DELETE FROM T_Customer WHERE C_id={Tmp} ";

            DBcontext Db = new DBcontext();
            Db.ExcuteNonQury(Sql);



        }




    }
}