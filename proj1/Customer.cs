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
        BindingList<CustomerClass> del;
        public Customer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            errorP.Clear();
            Regex checkId = new Regex(@"^([0-9]*)$");
            Regex checkName = new Regex(@"^([^0-9]*)$");
            
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

            else if (!checkId.IsMatch(txtId.Text))
            {
                errorP.SetError(txtId, "Customer Id can't include letters");
            }
            else if (!checkName.IsMatch(txtName.Text))
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
                        upd.Cells[3].Value = comboItem.Text;
                        upd.Cells[4].Value = comboCategory.Text;
                
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

        private void newDelete()
        {

            foreach (DataGridViewRow item in this.DGV.SelectedRows)
            {
                DGV.Rows.RemoveAt(item.Index);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            newDelete();
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
                comboItem.Text = "";
                comboCategory.Text = "";
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
                comboItem.Text = row.Cells[3].Value.ToString();
                comboCategory.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Type MisMatch");
            }
        }
    }
}
