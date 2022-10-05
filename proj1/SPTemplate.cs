using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proj1
{
   
    public partial class SPTemplate : UserControl
    {

        private string _sId;
        public string sId { get { return _sId; } set { _sId = value; IdT.Text = value; } }

        private string _sName;
        public string sName { get { return _sName; } set { _sName = value; NameT.Text = value; } }

        private string _sCategory;
        public string sCategory { get { return _sCategory; } set { _sCategory = value; CategoryT.Text = value; } }

        private string _sPrice;
        public string sPrice { get { return _sPrice; } set { _sPrice = value; PriceT.Text = value; } }

        private string _sQuantity;
        public string sQuantity { get { return _sQuantity; } set { _sQuantity = value; QuantityT.Text = value; } }

        private string _sTotal;
        public string sTotal { get { return _sTotal; } set { _sTotal = value; TotalT.Text = value; } }
        
        public SPTemplate()
        {
            InitializeComponent();
        }

        private void SPTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
