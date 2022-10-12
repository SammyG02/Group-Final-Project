using proj1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace proj1
{
    public partial class SellingPlace : Form
    {
        string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
        string itemRemaining="";
        string prodName = "";
        
        
        int index;

        public SellingPlace(string LN)
        {
            InitializeComponent();
            this.Controls.Add(UserCO);
            UserCO.Text = LN;
            Info(LN);
            
        }

        
        public void Info(string CusName)
        {
           
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "select * from Customers where CustomerName = '" + CusName + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();

            try
            {
                while (myReader.Read())
                {
                    //getting balances value from customer database using the Customername that is passed
                    //during login
                    //since balance is int type we read it as into and change it to string type

                    decimal customerBal = (decimal)myReader["CustomerBalance"];

                    lblBalance.Text = customerBal.ToString();
                    //setting lable to balance
                }

                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");

            }

        }
        
        /*public SellingPlace(int Id)
        {           
            
            InitializeComponent();

        }

        SellingPlaceClass SPC = new SellingPlaceClass(Id);*/

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Login().Show(); 
            this.Hide();
        }

        private void NameCO_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SellingPlace_Load(object sender, EventArgs e)
        {
            //getting the Item table from database
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Select itemId as Id,itemName as [Item Name],itemQuantity as Quantity,itemPrice as Price,categoryName as Category from Items i join Category c on i.catId = c.CategoryId";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            DGVCO.DataSource = dg;


            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void DGVCO_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow row = DGVCO.Rows[index];
                //getting data from selected Item table cells
                txtId.Text = row.Cells[0].Value.ToString();
                prodName = row.Cells[1].Value.ToString();
                itemRemaining = row.Cells[2].Value.ToString();
                lblPrice.Text = row.Cells[3].Value.ToString();
                




            }
            catch (Exception)
            {
                MessageBox.Show("Type MisMatch");
            }
        }

        private void DGVCO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ClearCO_Click(object sender, EventArgs e)
        {
            
            var confirmResult = MessageBox.Show("Are you sure to Clear the Textbox",
                                     "Clear the TextBox",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                txtId.Text = "";
                txtQuantity.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ErrP.Clear();
            Regex checkquantity = new Regex(@"^([0-9]*)$");
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show(txtQuantity, "Can't Add to Cart if Quantity is Empty!!");
            }
            else if (!checkquantity.IsMatch(txtQuantity.Text))
            {
                MessageBox.Show(txtQuantity, "Can't Add to Cart if Quantity has letters");
            }
            else
            {
                int totPrice = ((Int32.Parse(txtQuantity.Text)) * (Int32.Parse(lblPrice.Text)));


                decimal balance = decimal.Parse(lblBalance.Text);

                int itemLeft = Convert.ToInt32(itemRemaining);
                int itemWanted = Convert.ToInt32(txtQuantity.Text);
                lblTot.Text = totPrice.ToString();

                if (totPrice > balance)
                {
                    MessageBox.Show("You dont have Enough money!");

                }
                else if (itemLeft < itemWanted)
                {
                    MessageBox.Show("Not Enough Quantity In Stock");
                }
                else
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(cartDGV);
                    newRow.Cells[0].Value = txtId.Text;
                    newRow.Cells[1].Value = prodName;
                    newRow.Cells[2].Value = lblPrice.Text;
                    newRow.Cells[3].Value = txtQuantity.Text;
                    newRow.Cells[4].Value = Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(lblPrice.Text);

















                    //need to do work on database ..updating balance and quantity 











                    cartDGV.Rows.Add(newRow);

                }

            }
            


        }

        private void IdCO_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            int quant = 0;
            int uPrice = 0;
            ErrP.Clear();
            Regex checkquantity = new Regex(@"^([0-9]*)$");

            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                ErrP.SetError(txtQuantity, "Quantity is needed");
            }
            else if (!checkquantity.IsMatch(txtQuantity.Text))
            {
                ErrP.SetError(txtQuantity, "Quantity can't include letters");
            }
            else
            {
                quant = Int32.Parse(txtQuantity.Text);
                uPrice = Int32.Parse(lblPrice.Text);


                int totPrice = quant * uPrice;
                lblTot.Text = totPrice.ToString();

            }

            

            




        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
