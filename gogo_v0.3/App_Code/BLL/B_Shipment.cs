using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL
{
    public class B_Shipment
    {

        public int S_id{ get; set; }
        public int C_id { get; set; }
        public string S_dataStart { get; set; }
        public string S_dataEnd { get; set; }
        public int D_id { get; set; }
        public string S_Phone { get; set; }
        public string S_city{ get; set; }
        public string S_street { get; set; }
        public string S_numeH { get; set; }
        public int S_sumBox { get; set; }
        public int S_toDo { get; set; }
        public string S_picName { get; set; }
        public string S_dataDo { get; set; }
        public string S_msg { get; set;}

       


        public static List<B_Shipment> GetAll()
        {
            return D_Sheipments.GetAll();
        }
     
        




    }
}