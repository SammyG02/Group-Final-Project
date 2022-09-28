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
    public partial class Category : Form
    {

        int index;
        public Category()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorP.Clear();
            Regex checkId = new Regex(@"^([0-9]*)$");
            Regex checkName = new Regex(@"^([^0-9]*)$");



            if (string.IsNullOrEmpty(txtId.Text))
            {
                errorP.SetError(txtId, "Id is needed");
            }
            else if (string.IsNullOrEmpty(categoryname.Text))
            {
                errorP.SetError(categoryname, "Name is needed");
            }


            else if (!checkId.IsMatch(txtId.Text))
            {
                errorP.SetError(txtId, "Category Id can't include letters");
            }
            else if (!checkName.IsMatch(categoryname.Text))
            {
                errorP.SetError(categoryname, "Category Name can't include numbers");
            }


            else
            {
                try
                {
                    CategoryClass cate = new CategoryClass
                    {
                        CategoryID = int.Parse(txtId.Text),

                        CategoryName = categoryname.Text,

                    };
                    cate.Saved();
                    DGV.DataSource = null;
                    DGV.DataSource = CategoryClass.GetAllProducts();
                }

                catch (Exception)
                {
                    MessageBox.Show("Type MisMatch");
                }
            }
            }

            private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void Clearbtn_Click(object sender, EventArgs e)
            {
               var confirmResult = MessageBox.Show("Are you sure to Clear the Textbox",
                                         "Clear the TextBox",
                                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    txtId.Text = "";
                    categoryname.Text = "";

                }

                else { }
            }

            private void Deletbtn_Click(object sender, EventArgs e)
            {
                DataGridViewRow del = DGV.Rows[index];


                del.Cells[1].Value = "";
               

            }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
            {
                index = e.RowIndex;
                DataGridViewRow row = DGV.Rows[index];
                txtId.Text = row.Cells[0].Value.ToString();
                categoryname.Text = row.Cells[1].Value.ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Type MisMatch");
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
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
                    upd.Cells[1].Value = categoryname.Text;
                    
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
    }
    }


