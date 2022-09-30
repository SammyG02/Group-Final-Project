using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1
{
    class itemclass
    {

        static private List<itemclass> cat = new List<itemclass>();

        public string ID { get; set; }
        public string Item_Name { get; set; }
        public string Quntity { get; set; }
        public string Status { get; set; }
        //public string Catagory { get; set; }

        public void Saved()
        {
            cat.Add(this);

        }

        static public List<itemclass> GetAllProducts()
        {
            return cat;
        }
    }
}
