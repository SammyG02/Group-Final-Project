using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj1.Model
{
    internal class SignupClass
    {
        static private List<SignupClass> signup = new List<SignupClass>();

        public string signupName { get; set; }
        public string signupPassword { get; set; }
        public string signupConPassword { get; set; }







        public void InsertDataToAdmin()
        {
            signup.Add(this);

            //DBMS
            try
            {
                string connectionstring = @"Data Source = LAPTOP-T60OO29F\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string query = "insert into Admins (adminName,adminPassword) values ('" + this.signupName + "', '" + this.signupPassword + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Admin Successfully Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        

    }
}
