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

        public string itemID { get; set; }
        public string itemName { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }






        public void getCatId(String categoryName)
        {
            string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "select categoryId from Category where CategoryName = '"+categoryName+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader readId = cmd.ExecuteReader();


        }
        public void InsertData()
        {
            item.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "insert into Items values('" + this.itemID + "', '" + this.itemName + "', " +
                    "'" + this.Quantity + "', '" + this.Price +
                    "', '" + this.Status + "', '" + this.CategoryID +"')";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UpdateData()
        {
            //Grid
            item.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "update Items Set itemName = '" + this.itemName
                    + "', itemQuantity = '" + this.Quantity
                    + "', itemPrice = '" + this.Price
                    + "', itemstatus = '" + this.Status
                    + "', catId = '" + this.CategoryID
                    + "' Where itemId = '" + this.itemID + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        public void DeleteData()
        {
            //Grid
            item.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Delete from Items where itemId = '" + this.itemID + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Outofstock()
        {
            //Grid
            item.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "update Items Set itemQuantity = 0'"
                    + "' Where itemId = '" + this.itemID + "'";
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
