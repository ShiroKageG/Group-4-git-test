using Group4_Invidiual.Data.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4_Invidiual.Data.Forms
{
    public partial class LoginForm : Form
    {
        DataTable logincredit;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form Register = new Register(null);
            Register.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //AppUser.LoginCheck(UNameTxt.Text,PWordTxt.Text);
            string username, password;
            username = UNameTxt.Text;
            password = PWordTxt.Text;
            //try
            //{

            //catch
            //{
            //    MessageBox.Show("Error Code");
            //}
            string query = "Select * From AppUser Where Username ='"+ UNameTxt.Text + "' and Password = '"+PWordTxt.Text+"'";
            OracleCommand command = new OracleCommand(query);
            //command.Parameters.Add("P_sername", username);
            //command.Parameters.Add("P_Password", password);
            OracleDataAdapter adapter = new OracleDataAdapter(query, POSContext.GetConnection());

            DataTable dtable = new DataTable();
            adapter.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                username = UNameTxt.Text;
                password = PWordTxt.Text;

                Form Home = new HomeMenu();
                Home.Show();
            }
            else
            {
                MessageBox.Show("Womp Womp", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    
}
