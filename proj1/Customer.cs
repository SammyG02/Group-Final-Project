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

        int index;
        
        public Customer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorP.Clear();
            Regex checkId = new Regex(@"^([0-9]*)$");
            Regex checkName = new Regex(@"^([^0-9]*)$");
            Regex checkEmail = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
           

            if (string.IsNullOrEmpty(txtId.Text))
            {
                errorP.SetError(txtId, "Id is needed");
            }
            else if (string.IsNullOrEmpty(txtName.Text))
            {
                errorP.SetError(txtName, "Name is needed");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorP.SetError(txtEmail, "Email is needed");
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errorP.SetError(txtPhone, "Phone Number is needed");
            }
            else if (string.IsNullOrEmpty(txtAcc.Text))
            {
                errorP.SetError(txtAcc, "Account is needed");
            }

            else if (!checkId.IsMatch(txtId.Text))
            {
                errorP.SetError(txtId, "Customer Id can't include letters");
            }
            else if (!checkName.IsMatch(txtName.Text))
            {
                errorP.SetError(txtName, "Customer Name can't include numbers");
            }
            else if (!checkEmail.IsMatch(txtEmail.Text))
            {
                errorP.SetError(txtEmail, "Customer Email must include @");
                MessageBox.Show("Customer Email must include @");
            }
            else if (!checkId.IsMatch(txtPhone.Text))
            {
                errorP.SetError(txtPhone, "Phone can't include letters");
            }
            else if (!checkId.IsMatch(txtAcc.Text))
            {
                errorP.SetError(txtAcc, "Account Id can't include letters");
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
                        CustomerEmail = txtEmail.Text,
                        CustomerPhone = txtPhone.Text,
                        CustomerAcc = txtAcc.Text,
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
                       
            try
            {
                DataGridViewRow upd = DGV.Rows[index];

                var confirmResult = MessageBox.Show("Are you sure to update this row",
                                     "Update the list",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                
                        
                        upd.Cells[0].Value = txtId.Text;
                        upd.Cells[1].Value = dateTimePicker1.Text;
                        upd.Cells[2].Value = txtName.Text;
                        upd.Cells[3].Value = txtEmail.Text;
                        upd.Cells[4].Value = txtPhone.Text;
                        upd.Cells[5].Value = txtAcc.Text;
                }

                else
                {

                }
            
            }
            catch (Exception)
            {
                MessageBox.Show("User can't Update without adding something");
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DataGridViewRow del = DGV.Rows[index];

            
            del.Cells[1].Value = "";
            del.Cells[2].Value = "";
            del.Cells[3].Value = "";
            del.Cells[4].Value = "";
            del.Cells[5].Value = "";
           

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to Clear the Textbox",
                                     "Clear the TextBox",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                txtId.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                txtAcc.Text = "";
            }
             
            else { }
                        
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow row = DGV.Rows[index];
                txtId.Text = row.Cells[0].Value.ToString();
                dateTimePicker1.Text = row.Cells[1].Value.ToString();
                txtName.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtAcc.Text = row.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Type MisMatch");
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
