using Group4_Invidiual.Data.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4_Invidiual.Data.Forms
{
    public class AppUser
    {
        public static void UserAdd(Users user)
        {
            try
            {
                OracleCommand command = new OracleCommand("CreateUser", POSContext.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_Username", user.Username);
                command.Parameters.Add("P_Password", user.Password);

                command.ExecuteNonQuery();
                MessageBox.Show("Account Created", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Username Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
        //public static void LoginCheck(string username, string password)
        //{
            
        //    OracleCommand query = new OracleCommand("Select * From AppUser where Username = @Username and Password = @Password", POSContext.GetConnection());
        //    //command.ExecuteReader();
            
        //    OracleDataAdapter adapter = new OracleDataAdapter(query1, POSContext.GetConnection());

        //    DataTable dtable = new DataTable();
        //    adapter.Fill(dtable);

        //    if (dtable.Rows.Count == 1)
        //    {
        //        //username = UNameTxt.Text;
        //        //password = PWordTxt.Text;

        //        Form Home = new HomeMenu();
        //        Home.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Womp Womp", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
    
}
