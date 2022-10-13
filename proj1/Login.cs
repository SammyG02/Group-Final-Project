using proj1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proj1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            fillInCombo();
        }
        void fillInCombo()
        {
            string connectionstring = @"Data Source = LAPTOP-T60OO29F\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            string query = "select RoleName from Role";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();

            try
            {
                while (myReader.Read())
                {
                    String Roles = myReader.GetString(myReader.GetOrdinal("RoleName"));
                    loginRoleCb.Items.Add(Roles);

                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }


        private void label5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtLoginPassword.PasswordChar = '\0';

            }
            else
            {
                txtLoginPassword.PasswordChar = '*';

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new signUp().Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            Regex checkName = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(txtLoginName.Text))
            {
                errorProvider2.SetError(txtLoginName, "Name is needed");
            }
            else if (string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                errorProvider2.SetError(txtLoginPassword, "Password is needed");
            }
            
            else if (!checkName.IsMatch(txtLoginName.Text))
            {
                errorProvider2.SetError(txtLoginName, "Name can't include numbers");
            }
            else
            {
                try
                {
                    String role = loginRoleCb.SelectedItem.ToString();
                



                   


                        LoginClass ins = new LoginClass
                        {

                            loginName = txtLoginName.Text,
                            loginPassword = txtLoginPassword.Text,
                            loginRole = role,

                        };
                        int check = ins.check();
                        if (check == 10 || check == 1)
                        {
                            MessageBox.Show("Access Granted");
                            if (check == 1)//admin
                            {
                                new Form1(ins.loginName).Show();
                                this.Hide();
                            }
                            else if (check == 10)//customer
                            {

                                new SellingPlace(ins.loginName).Show();
                                this.Hide();

                            }

                        }

                        else //neither customer nor Admin
                        {
                            MessageBox.Show("Access Denied");
                        }



                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Type MisMatch");
                    }
                

            }
                
        }
    }
}
