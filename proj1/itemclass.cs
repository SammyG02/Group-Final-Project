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

        public int itemid { get; set; }
        public string itemname { get; set; }
        public int itemquant { get; set; }
        public bool status { get; set; }
        public string catagoreyname { get; set; }

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
