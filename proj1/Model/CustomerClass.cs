using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;

namespace proj1.Model
{
    internal class CustomerClass
    {
        static private BindingList<CustomerClass> custom = new BindingList<CustomerClass>();
      
        public int CustomerID { get; set; }
        public string CustomerDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerItem { get; set; }
        public string CustomerCategory { get; set; }

        public void Saved()
        {
            custom.Add(this);

        }

        static public BindingList<CustomerClass> GetAllProducts()
        {
            return custom;
        }
    }
}

