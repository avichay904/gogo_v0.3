using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;

  
namespace gogo_v0._3
{
    public class Services
    {

        




                
            // הפוקציה מקבלת מחרוזת ומחזירה טוקן ארוך של מחרוזת מוצפנת באופן אסימטרי
            // משמשת אותנו בעיקר עבור הצפנת סיסמת המשתמש בבסיס הנתונים
            // כך שאם יפרצו לבסיס הנתונים, לא יוכלו לדעת מה הסיסמה
            public static string Hash(string rawData)
            {
                // Create a SHA256  
                using (SHA256 sha256Hash = SHA256.Create())

                {
                    // ComputeHash - returns byte array  
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                    // Convert byte array to a string  
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }



            // פונקציה הקבלת נמען  לשליחת מיילים
            public static bool Send_Email(string To, string Subject, string body)
            {
                try
                {


                    MailMessage newMail = new MailMessage();
                    // use the Gmail SMTP Host
                    SmtpClient client = new SmtpClient("smtp.gmail.com");

                    // Follow the RFS 5321 Email Standard
                    newMail.From = new MailAddress("avichay904@gmail.com", "gogo");

                    newMail.To.Add(To);// declare the email subject

                    newMail.Subject = Subject; // use HTML for the email body

                    newMail.IsBodyHtml = true; newMail.Body = $"<p>{body}</p>";

                    // enable SSL for encryption across channels
                    client.EnableSsl = true;
                    // Port 465 for SSL communication
                    client.Port = 587;
                    // Provide authentication information with Gmail SMTP server to authenticate your sender account
                    client.Credentials = new System.Net.NetworkCredential("", "incynvqisezl");

                    client.Send(newMail);
                    return true;
                }

                catch
                {

                    return false;
                }

            }



            // הפונקציה מקבלת מחרוזת ומנקה תווים/מילים שעשוייים להוו בעיית אבטחה / הזרקה של קוד ב SQL
            public static string CleanSqlIngecsion(string str)
            {
                return str.Replace("'", "").Replace("select", "").Replace("delete", "").Replace("frome", "").Replace("DROP", "");
            }

            // הפונקציה מקבלת מחרוזת ומנקה תווים שעשויים להוות בעיה בשפת html
            public static string CleanHtml(string str)
            {
                return str.Replace("'", "\'").Replace("select", "").Replace("script", "").Replace(">", "");
            }



            // הפונקציה מקבלת מספר ומחזירה מחרוזת רנדומלית עם תווים בארוך המספר שקיבלה
            public static string GetRandStr(int size)
            {
                string st = "abcdefghijklmnopqrstuvwxyz0123456789";
                string RetVal = "";
                int i, index;
                Random rnd = new Random();
                for (i = 0; i < size; i++)
                {
                    index = rnd.Next(st.Length);
                    RetVal += st[index];
                }
                return RetVal;
            }

        
    }
}
