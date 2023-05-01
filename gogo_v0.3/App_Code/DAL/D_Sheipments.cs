using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Xml;
using BLL;

namespace DAL
{
    public class D_Sheipments
    {

        public static List<B_Shipment> GetAll()   // פונקציה השולפת את כול המשלוחים
        {
            List<B_Shipment> list = new List<B_Shipment>();
            string Sql = "SELECT * FROM T_Shipments";
            DBcontext Db = new DBcontext();
            DataTable Dt= new DataTable();
            Dt=Db.Excute(Sql);
            for(int i = 0; i < Dt.Rows.Count; i++)
            {
                B_Shipment tmp = new B_Shipment()
                {
                    S_id = int.Parse(Dt.Rows[i]["S_id"] + ""),
                    C_id = int.Parse(Dt.Rows[i]["C_id"] + ""),
                    S_dataStart = Dt.Rows[i]["S_dataStart"] + "",
                    S_dataEnd = Dt.Rows[i]["S_dataEnd"] + "",
                    D_id = int.Parse(Dt.Rows[i]["D_id"] + ""),
                    S_Phone = Dt.Rows[i]["S_phone"] + "",
                    S_city = Dt.Rows[i]["S_city"] + "",
                    S_street = Dt.Rows[i]["S_street"] + "",
                    S_numeH = Dt.Rows[i]["S_numeH"] + "",
                    S_toDo = int.Parse(Dt.Rows[i]["S_toDo"] + ""),
                    S_picName = Dt.Rows[i]["S_picName"] + "",
                    S_dataDo = Dt.Rows[i]["S_dataDo"] + "",
                    S_sumBox = int.Parse(Dt.Rows[i]["S_sumBox"] + ""),
                    S_msg = Dt.Rows[i]["S_msg"] + ""

                };
                list.Add(tmp);
                
                
            }

            Db.Close();


            return list;
        }


        public static void AddUpdate (B_Shipment Tmp)
        {

            string SQL = "";
                if (Tmp.S_id == -1)
            {
                SQL = $"INSERT INTO T_Shipments (C_id,S_dataStart,S_dataEnd,D_id,S_phone,S_city,S_street,S_numeH,S_sumBox,S_toDo,S_picName,S_dataDo,S_msg) Values ({Tmp.C_id},GETDATE(),'{Tmp.S_dataEnd}' ,{Tmp.D_id} ,'{Tmp.S_Phone}' ,N'{Tmp.S_city}', N'{Tmp.S_street}' ,'{Tmp.S_numeH}',{Tmp.S_sumBox},{Tmp.S_toDo},N'{Tmp.S_picName}','{Tmp.S_dataDo}',N'{Tmp.S_msg}' ) ";
                  
            }
            else
            {

                SQL = $"UPDATE T_Shipments SET C_id={Tmp.C_id},S_dataEnd='{Tmp.S_dataEnd}' ,D_id={Tmp.D_id},S_phone='{Tmp.S_Phone}',S_city='{Tmp.S_city}',S_street='{Tmp.S_street}',S_numeH='{Tmp.S_numeH}' ,S_sumBox={Tmp.S_sumBox},S_toDo={Tmp.S_toDo},S_picName='{Tmp.S_picName}',S_msg='{Tmp.S_msg}' WHERE S_id={Tmp.S_id} ";

            }


            DBcontext Db = new DBcontext();
              Db.ExcuteNonQury(SQL);

            Db.Close();


        }


       

        public static B_Shipment GetById (B_Shipment Tmp)
        {
            string Sql = $"SELECT * FROM T_Shipments WHERE S_id={Tmp.S_id}";

            DBcontext Db = new DBcontext();
            DataTable Dt = new DataTable();
            Dt = Db.Excute(Sql);
            Db.Close();



            for (int i = 0; i < Dt.Rows.Count; i++)
            {

                Tmp.C_id = int.Parse(Dt.Rows[i]["C_id"] + "");
                Tmp.S_dataStart = Dt.Rows[i]["S_dataStart"] + "";
                Tmp.S_dataEnd = Dt.Rows[i]["S_dataEnd"] + "";
                Tmp.D_id = int.Parse(Dt.Rows[i]["D_id"] + "");
                Tmp.S_Phone = Dt.Rows[i]["S_phone"] + "";
                Tmp.S_city = Dt.Rows[i]["S_city"] + "";
                Tmp.S_street = Dt.Rows[i]["S_street"] + "";
                Tmp.S_numeH = Dt.Rows[i]["S_numeH"] + "";
                Tmp.S_sumBox = int.Parse(Dt.Rows[i]["S_sumBox"] + "");
                Tmp.S_msg = Dt.Rows[i]["S_msg"] + "";


            }

            return Tmp;

        }


        public static void Delete(string Tmp)
        {
            string Sql = $"DELETE FROM T_Shipments WHERE S_id={Tmp} ";

            DBcontext Db = new DBcontext();
            Db.ExcuteNonQury(Sql);



        }

    }
}