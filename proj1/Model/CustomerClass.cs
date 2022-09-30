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
        static private List<CustomerClass> custom = new List<CustomerClass>();
      
        public string CustomerID { get; set; }
        public string CustomerDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAcc { get; set; }



        public void Saved()
        {
            custom.Add(this);

        }

        static public List<CustomerClass> GetAllProducts()
        {
            return custom;
        }
    }
}

