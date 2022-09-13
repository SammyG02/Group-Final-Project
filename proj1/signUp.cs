using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj1
{
    public partial class signUp : Form
    {
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
    }
}
