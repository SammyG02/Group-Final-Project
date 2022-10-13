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
    public partial class Form1 : Form
    {
        public Form1(String LN)
        {
            InitializeComponent();
            lblName.Text = LN;  
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.White;
            btnItems.ForeColor = Color.Gray;
            btnCategory.ForeColor = Color.Gray;
            btnHome.ForeColor = Color.Gray;

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Customer cust = new Customer();
            cust.MdiParent = this;
            cust.Show();
        }

        private void btnAlalytics_Click(object sender, EventArgs e)
        {
            btnItems.ForeColor = Color.White;
            btnCategory.ForeColor = Color.Gray;    
            btnCustomer.ForeColor = Color.Gray;
            btnHome.ForeColor = Color.Gray;
            
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Item cate = new Item();
            cate.MdiParent = this;
            cate.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackColor = this.BackColor;
                }

                catch(InvalidCastException exc)
                {

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnCalander_Click(object sender, EventArgs e)
        {
            btnItems.ForeColor = Color.Gray;
            btnCategory.ForeColor = Color.White;
            btnCustomer.ForeColor = Color.Gray;
            btnHome.ForeColor = Color.Gray;


            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Category cate = new Category();
            cate.MdiParent = this;
            cate.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnItems.ForeColor = Color.Gray;
            btnCategory.ForeColor = Color.Gray;
            btnCustomer.ForeColor = Color.Gray;
            btnHome.ForeColor = Color.White;

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }
    }
}
