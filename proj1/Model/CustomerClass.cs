using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1.Model
{
    internal class CustomerClass
    {
        static private List<CustomerClass> custom = new List<CustomerClass>();

        public int CustomerID { get; set; }
        public string CustomerDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerItem { get; set; }
        public string CustomerCategory { get; set; }

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
