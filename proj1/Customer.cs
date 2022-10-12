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
using System.Data.SqlClient;

namespace proj1
{
    

    public partial class Customer : Form
    {

        int index;

        string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";

        public Customer()
        {
            InitializeComponent();
        }

        
        //Add Button
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
            else if (string.IsNullOrEmpty(txtBal.Text))
            {
                errorP.SetError(txtBal, "Account is needed");
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                errorP.SetError(txtPass, "Password is needed");
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
            else if (!checkId.IsMatch(txtBal.Text))
            {
                errorP.SetError(txtBal, "Account Id can't include letters");
            }


            else
            {
                try
                {
                    CustomerClass ins = new CustomerClass
                    {
                        CustomerID = txtId.Text,                        
                        CustomerName = txtName.Text,
                        CustomerPass = txtPass.Text,
                        CustomerPhone = txtPhone.Text,
                        CustomerEmail = txtEmail.Text,                       
                        CustomerBal = decimal.Parse(txtBal.Text),                        
                        CustomerDate = dateTimePicker1.Text,
                    };
                    ins.InsertData();
                    DisplayData();
                }

                catch (Exception)
                {
                    MessageBox.Show("Type MisMatch");
                }
            }

        }

        //Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
                       
            try
            {
                

                var confirmResult = MessageBox.Show("Are you sure to Update this row",
                                     "Update the list",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                        CustomerClass upd = new CustomerClass
                        {
                            CustomerID = txtId.Text,
                            CustomerName = txtName.Text,
                            CustomerPass = txtPass.Text,
                            CustomerPhone = txtPhone.Text,
                            CustomerEmail = txtEmail.Text,
                            CustomerBal = decimal.Parse(txtBal.Text),
                            CustomerDate = dateTimePicker1.Text,
                        };
                        upd.UpdateData();
                        DisplayData();                                      
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
        
        //Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to Delete this row",
                                     "Delete the list",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    CustomerClass del = new CustomerClass
                    {
                        CustomerID = txtId.Text,


                    };
                    del.DeleteData();
                    DisplayData();
                }


                else
                {

                }

            }
            catch (Exception)
            {
                MessageBox.Show("User can't Delete without choosing something");
            }
            
        }

        
        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to Clear the Textbox",
                                     "Clear the TextBox",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                txtId.Text = "";
                txtName.Text = "";
                txtPass.Text = "";
                txtPhone.Text = "";
                txtEmail.Text = "";
                txtBal.Text = "";
                
            }
             
           
                        
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow row = DGV.Rows[index];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPass.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();                
                txtBal.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Type MisMatch");
            }
        }

        
        public void DisplayData()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Exec [Select Customers]";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            DGV.DataSource = dg;
        }
        
        private void Customer_Load(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Exec [Select Customers]";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            DGV.DataSource = dg;
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
