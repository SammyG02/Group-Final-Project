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
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace proj1
{
    public partial class SellingPlace : Form
    {
        string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";

        int index;

        public SellingPlace()
        {
            InitializeComponent();
            
        }

        
        public void getter()
        {
            
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

            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "Select itemId as Id,itemName as [Item Name],itemQuantity as Quantity,itemPrice as Price,itemStatus as Status,categoryName as Category from Items i join Category c on i.catId = c.CategoryId";
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);
            DataTable dg = new DataTable();
            cmd.Fill(dg);

            DGVCO.DataSource = dg;


            LoginClass lc = new LoginClass();
            UserCO.Text = lc.loginName;
            /*string query1 = "Select * from Customers";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlDataReader myReader;
            myReader = cmd1.ExecuteReader();
            myReader.Read();
            String customerName = myReader.GetString(myReader.GetOrdinal("CustomerName"));
            NameCO.Text = customerName;*/
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
                IdCO.Text = row.Cells[0].Value.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Type MisMatch");
            }
        }

        private void DGVCO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
