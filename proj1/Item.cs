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
        int tempcat = 1;
        //string catagoryinput = "temp";
        string connectionstring = @"Data Source = BATCOMPUTER\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";

        public Item()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void DisplayData()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Select * from Items";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            datagrid.DataSource = dg;
        }
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
                    itemclass item = new itemclass
                    {
                        ID = idtxt.Text,

                        Item_Name = nametxt.Text,

                        Quantity = quantitytxt.Text,

                        //Status = "true/temp",   

                        Price = pricetxt.Text,

                        CatagoryID = "1",

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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow upd = datagrid.Rows[index];

                var confirmResult = MessageBox.Show("Are you sure to update this row",
                                     "Update the list",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {


                    upd.Cells[0].Value = idtxt.Text;
                    upd.Cells[1].Value = nametxt.Text;
                    upd.Cells[2].Value = quantitytxt.Text;
                    //upd.Cells[3].Value = statCombo.Text;
                    //upd.Cells[4].Value = catagoryinput;
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

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow del = datagrid.Rows[index];


            del.Cells[0].Value = "";
            del.Cells[1].Value = "";
            del.Cells[2].Value = "";
            del.Cells[3].Value = "";
            //del.Cells[4].Value = "";
            

        }

        private void ousbtn_Click(object sender, EventArgs e)
        {

            DataGridViewRow del = datagrid.Rows[index];
            
            del.Cells[3].Value = "";
           
        }

        private void Item_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Select * from items";
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
               // status.Checked = row.Cells[4].Value.ToString();
                
                
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
