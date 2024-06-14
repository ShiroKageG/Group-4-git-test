using Group4_Invidiual.Data.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group4_Invidiual.Data.Forms
{
    public partial class Register : Form
    {
        Users users;
        bool IsNew;
        public Register(Users user)
        {
            this.users = user;
            InitializeComponent();


            if (user == null)
            {
                this.users = new Users();
                IsNew = true;
            }
            else
            {
                InitializeData();
                IsNew = false;
            }
        }
        public void InitializeData()
        {
            users.Username = NUserTxt.Text;
            users.Password = NPassTxt.Text;
            users.Password = CPassText.Text; 
        }
        public bool isUserExist(string username)
        {
            bool status = false;
            
            AppUser.UserAdd(users);


            if (CPassText.Text != NPassTxt.Text)
            {
                MessageBox.Show("Password does not match.");
            }


            return status;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form LoginForm = new LoginForm();
            LoginForm.Show();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
           
            InitializeData();
            if (string.IsNullOrEmpty(NUserTxt.Text) || string.IsNullOrEmpty(NPassTxt.Text) || string.IsNullOrEmpty(CPassText.Text))
            {
                MessageBox.Show("Please Fill The All Information");
            }
            
            else
            {
                isUserExist(NUserTxt.Text);
                //OracleDataAdapter adapter = new OracleDataAdapter(select);
                //adapter.GetType();
                //bool UserExist = false;
                //using (var check = select.ExecuteReader())

                    
                    
                        //AppUser.SelectUser(NUserTxt.Text);
                        
            }

        }
    }   
}
