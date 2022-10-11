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
using proj1.Model;

namespace proj1
{
    class itemclass
    {

        static private List<itemclass> item = new List<itemclass>();

        public string itemID { get; set; }
        public string itemName { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        
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
                string query = "Exec [Insert Items] ' " + this.itemID + " ', '"
                                + this.itemName + " ', '" + this.Quantity + " ', '" 
                                + this.Price + " ', '" + this.CategoryID + " ' ";
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
                string query = "Exec [Update Items] ' " + this.itemID + " ', '"
                                + this.itemName + " ', '" + this.Quantity + " ', '"
                                + this.Price + " ', '" + this.CategoryID + " ' ";
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
                string query = "Exec [Delete Items] ' " + this.itemID + " ' ";
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
            //Grid
            return item;

            //DBMS
            List<itemclass> finalp = new List<itemclass>();
            try
            {

                string connectionstring = @"Data Source =  LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Exec [Select Items]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    itemclass p = new itemclass();
                    p.itemID = (string)sdr["itemId"];
                    p.itemName = (string)sdr["itemName"];
                    p.Quantity = (string)sdr["itemQuantity"];
                    p.Price = (string)sdr["itemPrice"];
                    p.CategoryID = (int)sdr["catId"]; 
                    finalp.Add(p);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return finalp;
        }
    }
}
