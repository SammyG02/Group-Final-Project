using proj1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace proj1
{
    public partial class SellingPlace : Form
    {
        string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = False; User Id = Sellinglog;Password = Selllog";
        string itemRemaining="";
        string prodName = "";
        int grandTotal = 0;
        decimal customerBal = 0;
        int customerId = 0;
        String customerName = "";




        int index; 

        public SellingPlace(string LN)
        {
            InitializeComponent();
            this.Controls.Add(UserCO);
            customerName = LN;
            UserCO.Text = customerName;
            Info(customerName);
            
        }

        
        public void Info(string CusName)
        {
           
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Exec [CusName]'" + CusName + "'";
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

                    customerBal = (decimal)myReader["CustomerBalance"];
                    customerId = (int)myReader["CustomerId"];
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
            string query = "Exec [Insert Items and Category]";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            DGVCO.DataSource = dg;


            
        }
        public void DisplayData()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Exec [Insert Items and Category]";
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

                    grandTotal = grandTotal + totPrice;
                    if (grandTotal > balance)
                    {
                        grandTotal = grandTotal - totPrice;
                        MessageBox.Show("Insufficient jBalance");
                        lblGrandTot.Text = grandTotal.ToString();
                    }
                    else
                    {
                        
                        lblGrandTot.Text = grandTotal.ToString();
                        itemLeft = itemLeft - itemWanted;

                        try
                        {
                            string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                            SqlConnection con = new SqlConnection(connectionstring);
                            con.Open();
                            MessageBox.Show("stored");
                            string query = "Exec [Update Quantity] '" + txtId.Text + "', '"
                                            + itemLeft + "'";
                            SqlCommand cmd = new SqlCommand(query, con);
                            var result = cmd.ExecuteNonQuery();
                            con.Close();
                            //MessageBox.Show("After");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        DisplayData();
                        cartDGV.Rows.Add(newRow);

                    }


                    



                    //need to do work on database ..updating balance and quantity 





                    

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
        public void UpdateBal()
        {

            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                
                string query = "Exec [Update Balance] '" + customerId + "', '"
                                + customerBal + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //checkout button
            MessageBox.Show("Purchase was a success!!");
            customerBal = customerBal - grandTotal;
            lblBalance.Text= customerBal.ToString();
            grandTotal = 0;
            lblGrandTot.Text="0";
            UpdateBal();

            new SellingPlace(customerName).Show();
            this.Hide();


        }
    }
}
