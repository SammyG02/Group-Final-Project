using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace proj1
{
    class itemclass
    {

        static private List<itemclass> item = new List<itemclass>();

        public string ID { get; set; }
        public string Item_Name { get; set; }
        public string Quantity { get; set; }
        public int Price { get; set; }
        public bool Status { get; set; }
        public int CatagoryID { get; set; }

        //public string Catagory { get; set; }

        public void InsertData()
        {
            item.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data Source = LAPTOP-T60OO29F\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "insert into Items values('" + this.ID + "', '" + this.Item_Name + "', " +
                    "'" + this.Quantity + "', '" + this.Price +
                    "', '" + this.Status + "', '" + this.CatagoryID + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        static public List<itemclass> GetAllProducts()
        {
            return item;
        }
    }
}
