using proj1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace proj1
{
    public partial class Item : Form
    {
        int index;
        string catagoryinput = "temp";
       
        public Item()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = catagoryinput;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorhandler.Clear();
            Regex checkId = new Regex(@"^([0-9]*)$");
            Regex checkName = new Regex(@"^([^0-9]*)$");
            Regex checkquantity = new Regex(@"^([0-9]*)$");


            if (string.IsNullOrEmpty(nametxt.Text))
            {
                errorhandler.SetError(nametxt, "Name is needed");
            }
            else if (string.IsNullOrEmpty(idtxt.Text))
            {
                errorhandler.SetError(idtxt, "Name is needed");
            }
            else if (string.IsNullOrEmpty(quantitytxt.Text))
            {
                errorhandler.SetError(idtxt, "Quantity not provided, set value to 1");
            }

            else if (!checkId.IsMatch(idtxt.Text))
            {
                errorhandler.SetError(idtxt, "Catagory Id can't include letters");
            }
            else if (!checkName.IsMatch(nametxt.Text))
            {
                errorhandler.SetError(nametxt, "Catagory Name can't include numbers");
            }
            else if (!checkquantity.IsMatch(quantitytxt.Text))
            {
                errorhandler.SetError(quantitytxt, "Catagory Quantity can't include letters");
            }


            else
            {
                try
                {
                    itemclass cate = new itemclass
                    {
                        itemid = int.Parse(idtxt.Text),

                        itemname = nametxt.Text,

                        itemquant = int.Parse(quantitytxt.Text),

                        status = statchk.Checked,

                        catagoreyname = catagoryinput,

                    };
                    cate.Saved();
                    datagrid.DataSource = null;
                    datagrid.DataSource = CategoryClass.GetAllProducts();
                }

                catch (Exception)
                {
                    MessageBox.Show("Type MisMatch");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow upd = datagrid.Rows[index];

                var confirmResult = MessageBox.Show("Are you sure to update this row",
                                     "Update the list",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {


                    upd.Cells[0].Value = idtxt.Text;
                    upd.Cells[1].Value = nametxt.Text;
                    upd.Cells[2].Value = quantitytxt.Text;
                    upd.Cells[3].Value = statchk.Checked;
                    upd.Cells[4].Value = catagoryinput;
                }

                else
                {

                }

            }
            catch (Exception)
            {
                MessageBox.Show("User can't Update without adding something");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
