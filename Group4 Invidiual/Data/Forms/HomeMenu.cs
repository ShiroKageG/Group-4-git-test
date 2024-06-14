using Group4_Invidiual.Data.Models;
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
    public partial class HomeMenu : Form
    {
        DataTable dtCustomer;
        public HomeMenu()
        {
            InitializeComponent();
            InitializeData();
        }

        public void InitializeData()
        {
            dtCustomer = Customers.GetAll();

            dgCustomer.DataSource = dtCustomer;

            dgCustomer.Columns[0].Visible = false;

            dgCustomer.Columns[1].Visible = true;
            dgCustomer.Columns[1].HeaderText = "Name";
            dgCustomer.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomer.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgCustomer.Columns[2].Visible = false;
            dgCustomer.Columns[3].Visible = false;
            dgCustomer.Columns[4].Visible = false;
            dgCustomer.Columns[5].Visible = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void HomeMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            CustomerAddEdit form = new CustomerAddEdit(null);
            if(form.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if(dgCustomer.Rows.Count <= 0)
             return;

            int customerid = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            Customer customer = Customers.Get(customerid);

            CustomerAddEdit form = new CustomerAddEdit(customer);
            
            if(form.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count <= 0)
                return;
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (confirm != DialogResult.Yes)
                return;

            int customerid = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            Customers.Delete(customerid);

            MessageBox.Show("Successful");
            InitializeData();


        }

        private void dgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count <= 0)
                return;
            int customerid = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerID"].Value.ToString());
            Customer customer = Customers.Get(customerid);
            if(customer != null)
            {
                DataCBox.Text = customer.CustomerName;
                DataComBox.Text = customer.CompanyName;
                DataPhoneBox.Text = customer.Phone;
                DataEmailBox.Text = customer.Email;
                DataAddressBox.Text = customer.Address;
            }
        }
    }
}
