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
    public partial class CustomerAddEdit : Form
    {
        Customer customer;
        bool IsNew;
        public CustomerAddEdit(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
            if (customer == null)
            {
                lblTitle.Text = "New Customer";
                this.customer = new Customer();
                IsNew = true;
            }
            else
            {
                lblTitle.Text = "Edit Customer";
                InitializeDate();
                SaveBtn.Text = "Update";
                IsNew = false;
            }
        }
        void InitializeDate()
        {
            CNameBox.Text = customer.CustomerName;
            ComNameBox.Text = customer.CompanyName;
            PhoneBox.Text = customer.Phone;
            EmailBox.Text = customer.Email;
            AddressBox.Text = customer.Address;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            customer.CustomerName = CNameBox.Text;
            customer.CompanyName = ComNameBox.Text;
            customer.Phone = PhoneBox.Text;
            customer.Email = EmailBox.Text;
            customer.Address = AddressBox.Text;
            if (IsNew)
            {
                Customers.Add(customer);
            }
            else
            {
                Customers.Update(customer);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
