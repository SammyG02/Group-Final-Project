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
        String Adminname = "";

        public Form1(string l)
        {
            InitializeComponent();
            this.Controls.Add(UserAd);
            Adminname = l;
            UserAd.Text = Adminname;
            
        }

        //Customer Button
        private void btnContact_Click(object sender, EventArgs e)
        {
            btnCustomer.ForeColor = Color.White;
            btnItems.ForeColor = Color.FromArgb(0, 126, 249);
            btnCategory.ForeColor = Color.FromArgb(0, 126, 249);
            btnHome.ForeColor = Color.FromArgb(0, 126, 249);
            

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Customer cust = new Customer();
            cust.MdiParent = this;
            cust.Show();
        }

        
        //Items
        private void btnAlalytics_Click(object sender, EventArgs e)
        {
            btnItems.ForeColor = Color.White;
            btnCategory.ForeColor = Color.FromArgb(0, 126, 249);    
            btnCustomer.ForeColor = Color.FromArgb(0, 126, 249);
            btnHome.ForeColor = Color.FromArgb(0, 126, 249);

            
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

        
        //Category
        private void btnCalander_Click(object sender, EventArgs e)
        {
            btnItems.ForeColor = Color.FromArgb(0, 126, 249);
            btnCategory.ForeColor = Color.White;
            btnCustomer.ForeColor = Color.FromArgb(0, 126, 249);
            btnHome.ForeColor = Color.FromArgb(0, 126, 249);


            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Category cate = new Category();
            cate.MdiParent = this;
            cate.Show();
        }

        
        //Home
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnItems.ForeColor = Color.FromArgb(0, 126, 249);
            btnCategory.ForeColor = Color.FromArgb(0, 126, 249);
            btnCustomer.ForeColor = Color.FromArgb(0, 126, 249);
            btnHome.ForeColor = Color.White;

            MdiClient ctlMDI;

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackColor = Color.FromArgb(24, 30, 54);
                }

                catch (InvalidCastException exc)
                {

                }
            }

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            
            Category cate = new Category();
            cate.MdiParent = this;
            cate.Hide();

            Item ite = new Item();
            ite.MdiParent = this;
            ite.Hide();

            Customer cust = new Customer();
            cust.MdiParent = this;
            cust.Hide();

            Home home = new Home();
            home.MdiParent = this;
            home.Show();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.Controls.Add(UserAd);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Controls.Add(UserAd);
        }
    }
}
