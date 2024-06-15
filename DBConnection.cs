using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKMS
{
    public class DBConnection
    {
        private static string DBConn = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\BankMS.mdf;Integrated Security=True";
        private SqlConnection con = new SqlConnection(DBConn);

        public SqlConnection GetConnection()
        {
            return con;
        }
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
