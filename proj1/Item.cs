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
    public partial class Item : Form
    {
        int index;
        
        //string catagoryinput = "temp";
        string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";

        public Item()
        {
            InitializeComponent();
            fillCombo();
        }

         void fillCombo()
        {
            string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
            string query = "select categoryName from Category";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myReader;  
                myReader = cmd.ExecuteReader();

            try
            {
                while (myReader.Read())
                {
                    String cateName = myReader.GetString(myReader.GetOrdinal("categoryName"));
                    //String cateId = myReader.GetInt32(myReader.GetOrdinal("categoryId")).ToString();
                    //int catId = Int32.Parse(cateId);

                    catrgoryCb.Items.Add(cateName);

                }
                con.Close(); 
            }
            catch (Exception ex)
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void DisplayData()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Select itemId as Id,itemName as [Item Name],itemQuantity as Quantity,itemPrice as Price,categoryName as Category from Items i join Category c on i.catId = c.CategoryId";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            datagrid.DataSource = dg;
        }

        //add button click
        private void button1_Click(object sender, EventArgs e)
        {
            errorhandler.Clear();
            Regex checkId = new Regex(@"^([0-9]*)$");
            Regex checkName = new Regex(@"^([^0-9]*)$");
            Regex checkquantity = new Regex(@"^([0-9]*)$");
            Regex checkprice = new Regex(@"^([0-9]*)$");

            if (string.IsNullOrEmpty(nametxt.Text))
            {
                errorhandler.SetError(nametxt, "Name is needed");
            }
            else if (string.IsNullOrEmpty(idtxt.Text))
            {
                errorhandler.SetError(idtxt, "ID is needed");
            }
            else if (string.IsNullOrEmpty(quantitytxt.Text))
            {
                errorhandler.SetError(idtxt, "Quantity not provided, set value to 1");
            }
            else if (string.IsNullOrEmpty(pricetxt.Text))
            {
                errorhandler.SetError(pricetxt, "price not provided");
            }

            else if (!checkId.IsMatch(idtxt.Text))
            {
                errorhandler.SetError(idtxt, " Id can't include letters");
            }
            else if (!checkName.IsMatch(nametxt.Text))
            {
                errorhandler.SetError(nametxt, " Name can't include numbers");
            }
            else if (!checkquantity.IsMatch(quantitytxt.Text))
            {
                errorhandler.SetError(quantitytxt, "Quantity can't include letters");
            }
            else if (!checkprice.IsMatch(pricetxt.Text))
            {
                errorhandler.SetError(pricetxt, "price can't include letters");
            }


            else
            {
                try
                {
                    String CategoryName = catrgoryCb.SelectedItem.ToString();
                    SqlConnection con = new SqlConnection(connectionstring);
                    con.Open();
                    string query = "Select categoryId from Category where categoryName = '"+CategoryName+"'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    Int32 categoryIdValue = Convert.ToInt32(cmd.ExecuteScalar());
                    itemclass item = new itemclass
                    {
                        itemID = idtxt.Text,

                        itemName = nametxt.Text,

                        Quantity = quantitytxt.Text,

                        Price = pricetxt.Text,
                        CategoryID = categoryIdValue,




                        //needs a real value 

                    };
                    item.InsertData();
                    DisplayData();
                    
                    //datagrid.DataSource = null;
                   // datagrid.DataSource = itemclass.GetAllProducts();
                }

                catch (Exception)
                {
                    MessageBox.Show("Type MisMatch");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//UPDATE BUTTON
        {
            try
            {


                var confirmResult = MessageBox.Show("Are you sure to Update this row",
                                     "Update the list",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    String CategoryName = catrgoryCb.SelectedItem.ToString();
                    SqlConnection con = new SqlConnection(connectionstring);
                    con.Open();
                    string query = "Select categoryId from Category where categoryName = '" + CategoryName + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    Int32 categoryIdValue = Convert.ToInt32(cmd.ExecuteScalar());

                    itemclass upd = new itemclass
                    {
                        itemID = idtxt.Text,

                        itemName = nametxt.Text,

                        Quantity = quantitytxt.Text,

                        

                        Price = pricetxt.Text,

                        CategoryID = categoryIdValue,
                        //needs a real value 

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

        private void button3_Click(object sender, EventArgs e)//DELETE BUTTON
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure to Delete this row",
                                     "Delete the list",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    itemclass del = new itemclass
                    {
                        itemID = idtxt.Text,
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

        private void ousbtn_Click(object sender, EventArgs e)
        {
            //clearbtn

            var confirmResult = MessageBox.Show("Are you sure to Clear the Textbox",
                                         "Clear the TextBox",
                                         MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                idtxt.Text = "";
                nametxt.Text = "";
                quantitytxt.Text = "";
                pricetxt.Text = "";

            }

            else { }

        }

        private void Item_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Select itemId as Id,itemName as [Item Name],itemQuantity as Quantity,itemPrice as Price,categoryName as Category from Items i join Category c on i.catId = c.CategoryId";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            datagrid.DataSource = dg;
        }

        private void datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                DataGridViewRow row = datagrid.Rows[index];
                idtxt.Text = row.Cells[0].Value.ToString();
                nametxt.Text = row.Cells[1].Value.ToString();
                quantitytxt.Text = row.Cells[2].Value.ToString();
                pricetxt.Text = row.Cells[3].Value.ToString();
               
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Type MisMatch");
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
