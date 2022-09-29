using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj1
{
    internal class CategoryClass
    {
        static private List<CategoryClass> cat = new List<CategoryClass>();

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        
    public void Saved()
        {
            cat.Add(this);

        }

        static public List<CategoryClass> GetAllProducts()
        {
            return cat;
        }
    }
}
