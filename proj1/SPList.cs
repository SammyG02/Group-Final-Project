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
    public partial class SPList : Form
    {
       

        public SPList(string IID, string IName, int ICat, string IPrice)
        {
            InitializeComponent();
            
            this.Controls.Add(IdT);
            this.Controls.Add(NameT);
            this.Controls.Add(CategoryT);
            this.Controls.Add(PriceT);

            IdT.Text = IID;
            NameT.Text = IName;
            CategoryT.Text = ICat.ToString();
            PriceT.Text = IPrice;

            
        }

        private void SPList_Load(object sender, EventArgs e)
        {
            
        }
    }
}
