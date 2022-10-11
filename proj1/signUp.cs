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

namespace proj1
{
    public partial class signUp : Form
    {
        string connectionstring = @"Data Source = LAPTOP-BBJ3R5V0\SQLEXPRESS; Initial Catalog = FinalProject; Integrated Security = True;";
        public signUp()
        {
            InitializeComponent();
            
        }
        
        
        private void signUp_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSignupShowPassword.Checked)
            {
                txtSignupPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';

            }
            else
            {
                txtConPassword.PasswordChar = '*';
                txtSignupPassword.PasswordChar = '*';

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Regex checkName = new Regex(@"^([^0-9]*)$");
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Name is needed");
            }
            else if (string.IsNullOrEmpty(txtSignupPassword.Text))
            {
                errorProvider1.SetError(txtSignupPassword, "Password is needed");
            }
            else if (string.IsNullOrEmpty(txtConPassword.Text))
            {
                errorProvider1.SetError(txtConPassword, "Confirm Password");
            }
            else if (!checkName.IsMatch(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Name can't include numbers");
            }
            else
            {
                
                if(txtConPassword.Text == txtSignupPassword.Text)
                {
                    try
                    {
                        SignupClass ins = new SignupClass
                        {

                            signupName = txtName.Text,
                            signupPassword = txtSignupPassword.Text
                            
                            
                        };
                        ins.InsertDataToAdmin();

                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Type MisMatch");
                    }

                }
                else
                {
                    MessageBox.Show("Passwords didn't match ... Faild");
                }
               
                   

                



            }
        }
    }
}
