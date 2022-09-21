using proj1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace proj1
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorP.Clear();
            Regex checkN = new Regex(@"^([^0-9]*)$");

            if (string.IsNullOrEmpty(txtId.Text))
            {
                errorP.SetError(txtId, "Id is needed");
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                errorP.SetError(txtName, "Name is needed");
            }
            else if (string.IsNullOrEmpty(comboItem.Text))
            {
                errorP.SetError(comboItem, "Name is needed");
            }
            else if (string.IsNullOrEmpty(comboCategory.Text))
            {
                errorP.SetError(comboCategory, "Name is needed");
            }


            else if (!checkN.IsMatch(txtName.Text))
            {
                errorP.SetError(txtName, "Customer Name can't include numbers");
            }

            else
            {
                try
                {
                    CustomerClass cc = new CustomerClass
                    {
                        CustomerID = int.Parse(txtId.Text),
                        CustomerDate = dateTimePicker1.Text,
                        CustomerName = txtName.Text,
                        CustomerItem = comboItem.Text,
                        CustomerCategory = comboCategory.Text,

                    };
                    cc.Saved();
                    DGV.DataSource = null;
                    DGV.DataSource = CustomerClass.GetAllProducts();
                }

                catch (Exception)
                {
                    MessageBox.Show("Type MisMatch");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtId.Text = "";
            txtName.Text = "";
            comboItem.Text = "";
            comboCategory.Text = "";

        }
    }
}
