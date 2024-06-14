using Group4_Invidiual.Data.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group4_Invidiual.Data
{
    public class Customers
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("PoSCustomerGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            return table;
        }
        public static Customer Get(int customerid)
        {
            OracleCommand command = new OracleCommand("PoSCustomerGet", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_CustomerID", customerid);
            Customer customer = null;
            OracleDataReader reader = command.ExecuteReader(); 
            if (reader.Read())
            {
                customer = new Customer();
                customer.CustomerID = Convert.ToInt32(reader["CustomerID"]);
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.CompanyName = reader["CompanyName"].ToString();
                customer.Phone = reader["Phone"].ToString();
                customer.Email = reader["Email"].ToString();
                customer.Address = reader["Address"].ToString();
            }
            return customer;
        }
        public static void Add(Customer customer)
        {
            OracleCommand command = new OracleCommand("PoSCustomerAdd", POSContext.GetConnection());
            command.CommandType= CommandType.StoredProcedure;

            //command.Parameters.Add("P_CustomerID", customer.CustomerID);
            command.Parameters.Add("P_CustomerName", customer.CustomerName);
            command.Parameters.Add("P_CompanyName", customer.CompanyName);
            command.Parameters.Add("P_Phone", customer.Phone);
            command.Parameters.Add("P_Email", customer.Email);
            command.Parameters.Add("P_Address", customer.Address);

            command.ExecuteNonQuery();
        }

        public static void Update(Customer customer)
        {
            OracleCommand command = new OracleCommand("PoSCustomerUpdate", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_CustomerID", customer.CustomerID);
            command.Parameters.Add("P_CustomerName", customer.CustomerName);
            command.Parameters.Add("P_CompanyName", customer.CompanyName);
            command.Parameters.Add("P_Phone", customer.Phone);
            command.Parameters.Add("P_Email", customer.Email);
            command.Parameters.Add("P_Address", customer.Address);

            command.ExecuteNonQuery();
        }
        public static void Delete(int customerid)
        {
            OracleCommand command = new OracleCommand("PoSCustomerDelete", POSContext.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_CustomerID", customerid);

            command.ExecuteNonQuery();
        }

    }
}
