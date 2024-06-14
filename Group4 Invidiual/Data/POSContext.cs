using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_Invidiual.Data
{
    public class POSContext
    {
        static OracleConnection con;
        public static void OpenConnection()
        {
            if (con == null)
            {
                con = new OracleConnection();
                con.ConnectionString = "Data Source=localhost: 1521/XEPDB1; User Id=POS; Password=1234;";
                con.Open();

            }
        }
        public static void CloseConnection()
        {
            if (con != null)
            {
                con.Close();
            }
        }
        public static OracleConnection GetConnection()
        {
            if (con == null)
                OpenConnection();

            return con;
        }
    }
}
