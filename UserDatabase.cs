using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Data;

namespace messengerTest
{
    internal class UserDatabase
    {
        SqlConnection conn;
        public UserDatabase() {
                                     
            conn = new SqlConnection("Data Source=DESKTOP-N3G2RBD;Initial Catalog=UserDatabase;Integrated Security=True");
        }

        public int Login(string email, string password)
        {
            try
            {
                String querry = "SELECT * FROM UserData WHERE email = '" + email + "' AND password = '" + password + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
                if(dtable.Rows.Count > 0)
                {
                    Console.WriteLine("succesfull login");
                    Console.WriteLine(dtable.Rows[0][3].ToString());
                    return Int32.Parse(dtable.Rows[0][3].ToString()) ;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("unsuccesfull login");
                return 0;
            }
            finally 
            {
                conn.Close();
            }
            return 0;
        }

        public string GetUserName(int id)
        {
            try
            {
                String querry = "SELECT * FROM UserData WHERE id = '" + id + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                adapter.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    return dtable.Rows[0][0].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

    }   
}
