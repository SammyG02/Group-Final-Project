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

namespace proj1.Model
{
    internal class CustomerClass
    {
        static private List<CustomerClass> custom = new List<CustomerClass>();
      
        public string CustomerID { get; set; }
        public string CustomerDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public decimal CustomerBal { get; set; }
        public string CustomerPass { get; set; }
        




        public void InsertData()
        {
            //Grid
            custom.Add(this);

            //DBMS
            try
            {
                //LAPTOP-BBJ3R5V0\SQLEXPRESS
                //LAPTOP-T60OO29F\SQLEXPRESS
                //
                //
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Exec [Insert Customers] '" + this.CustomerID + "', '" 
                                + this.CustomerName + "', '" + this.CustomerPass + "', '" 
                                + this.CustomerPhone + "', '" + this.CustomerEmail + "', '"
                                + this.CustomerBal + "', '" + this.CustomerDate + "'";
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
            custom.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Exec [Update Customers] '" + this.CustomerID + "', '"
                                + this.CustomerName + "', '" + this.CustomerPass + "', '"
                                + this.CustomerPhone + "', '" + this.CustomerEmail + "', '"
                                + this.CustomerBal + "', '" + this.CustomerDate + "'";
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
            custom.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Exec [Delete Customers] '" + this.CustomerID + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public List<CustomerClass> GetAllProducts()
        {
            //Grid
            return custom;

            //DBMS
            List<CustomerClass> finalp = new List<CustomerClass>();
            try
            {

                string connectionstring = @"Data Source =  LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "Exec [Select Customers]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    CustomerClass p = new CustomerClass();
                    p.CustomerID = (string)sdr["CustomerID"];
                    p.CustomerName = (string)sdr["CustomerName"];
                    p.CustomerPass = (string)sdr["CustomerPassword"];
                    p.CustomerPhone = (string)sdr["CustomerPhone"];
                    p.CustomerEmail = (string)sdr["CustomerEmail"];
                    p.CustomerBal = (decimal)sdr["CustomerBalance"];
                    p.CustomerDate = (string)sdr["dates"];
                    finalp.Add(p);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return custom;
        }
    }
}

