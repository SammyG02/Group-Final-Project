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
    public partial class Category : Form
    {

        int index;
        string connectionstring = @"Data Source = LAPTOP-1M9P6SFG\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
        public Category()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //AddButton
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
                        CategoryID = txtId.Text,

                        CategoryName = categoryname.Text,

                    };
                    cate.InsertData();
                    DisplayData();
                    
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
              
               //ClearButton
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
               
              //DeleteButton
            private void Deletbtn_Click(object sender, EventArgs e)
            {
            CategoryClass del = new CategoryClass
            {
                CategoryID = txtId.Text,
            };
            del.DeleteData();
            DisplayData();


        }

              //DataGridView
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

       

        
            //UpdateButton
        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {


                var confirmResult = MessageBox.Show("Are you sure to update this row",
                                     "Update the list",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    CategoryClass upd = new CategoryClass
                    {
                        CategoryID = txtId.Text,
                        CategoryName = categoryname.Text,
                        
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
            
        public void DisplayData()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "select * from Category";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            DGV.DataSource = dg;
        }

        private void Category_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Select * from Category";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            DGV.DataSource = dg;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }


