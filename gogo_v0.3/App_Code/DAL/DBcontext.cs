using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;//יש להוסיף ספריות אילו כדי לעבוד עם המסד נתונים
using System.Data.SqlClient;//ספריה המכילה חיבור לSQL
using System.Configuration;// מכיל אפשרות גישה להגדרות מערכת


namespace DAL
{
    public class DBcontext
    {

        public string ConStr { get; set; }
        public SqlConnection Conn { get; set; }

        public SqlCommand Cmd { get; set; }


        public DBcontext()
        {
            this.ConStr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            this.Conn = new SqlConnection(this.ConStr); //אובייקט מסוג צינור מקבל מחרוזת התחברות
            Conn.Open();


        }

        // פונקציה המקבלת שאילתה ומחזירה טבלה 


        public DataTable Excute(string Sql)
        {
            DataTable Dt = new DataTable();
            this.Cmd = new SqlCommand(Sql, Conn);//אובייקט בסוג פקודה המקבלת שאילתה וצינור

            SqlDataAdapter DataAdapter = new SqlDataAdapter(this.Cmd);
            DataAdapter.Fill(Dt);


            return Dt;
        }


        // פונקציה להפעלת שאילתות של הוספה עדכון ומחיקה
        public int ExcuteNonQury(string Sql)
        {

            Cmd = new SqlCommand(Sql, Conn);
            return Cmd.ExecuteNonQuery();


        }

        // פונקציה המחזירה תא בודד 


        public object ExcuteScalar(string Sql)
        {

            Cmd = new SqlCommand(Sql, Conn);

            return Cmd.ExecuteScalar();

        }

        public void Close()
        {
            Conn.Close();
        }


    }
}
