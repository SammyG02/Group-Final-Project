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
    internal class CategoryClass
    {
        static private List<CategoryClass> cat = new List<CategoryClass>();

        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        
    public void InsertData()
        {
            //Grid
            cat.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data source =  LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog= FinalProject; Integrated security= True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Exec [Insert Category] ' " + this.CategoryID + " ', '"
                                + this.CategoryName + " ' ";
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
            cat.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog= FinalProject; Integrated security= True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Exec [Update Category] ' " + this.CategoryID + " ', '"
                                + this.CategoryName + " ' ";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    public void DeleteData()
        {
            //Grid
            cat.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog= FinalProject; Integrated security= True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Exec [Delete Category] ' " + this.CategoryID + " ' ";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        static public List<CategoryClass> GetAllProducts()
        {
            //Grid
            return cat;

            //DBMS
            List<CategoryClass> finalp = new List<CategoryClass>();
            try
            {
                string connectionstring = @"Data source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog= FinalProject; Integrated security= True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Exec [Select Category]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    CategoryClass c = new CategoryClass();
                    c.CategoryID = (string)sdr["CategoryID"];
                    c.CategoryName = (string)sdr["CategoryName"];
                    finalp.Add(c);
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cat;
        }
    }
}
