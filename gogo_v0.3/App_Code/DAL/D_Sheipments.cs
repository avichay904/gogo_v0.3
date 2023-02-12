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

        public static List<B_Shipment> GetAll()
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
                    S_dataDO = Dt.Rows[i]["S_dataDo"] + "",
                    S_sumBox = int.Parse(Dt.Rows[i]["S_sumBox"] + ""),
                    S_msg = Dt.Rows[i]["S_msg"] + ""

                };
                list.Add(tmp);
                
                
            }

            Db.Close();


            return list;


        }
       
    }
}