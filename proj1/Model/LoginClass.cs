using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj1.Model
{
    internal class LoginClass
    {
        static private List<LoginClass> login = new List<LoginClass>();

        public string loginName { get; set; }
        public string loginPassword { get; set; }

        public string loginRole { get; set; }


        public int check()
        {
            int checker=0;
            string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";

            if (loginRole == "Admin")
            {
                checker = 2;
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "select * from Admins";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();

                try
                {
                    while (myReader.Read() && checker==2)
                    {
                        String adminName = myReader.GetString(myReader.GetOrdinal("AdminName"));
                        String adminPassword = myReader.GetString(myReader.GetOrdinal("AdminPassword"));

                        if (adminName.Equals(loginName) && adminPassword.Equals(loginPassword))
                        {
                            checker = 1;
                            //break;
                        }
         
                    }
                    
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");

                }








            }
            else if(loginRole == "Customer")
            {
                checker = 3;
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "select * from Customers";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myReader;
                myReader = cmd.ExecuteReader();

                try
                {
                    while (myReader.Read() && checker == 3)
                    {
                        String customerName = myReader.GetString(myReader.GetOrdinal("CustomerName"));
                        String customerPassword = myReader.GetString(myReader.GetOrdinal("CustomerPassword"));

                        if (customerName.Equals(loginName) && customerPassword.Equals(loginPassword))
                        {
                            checker = 10;

                            //break;
                        }

                    }
                    
                    
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error");

                }

            }
            return checker;

        }
       








    }
}
