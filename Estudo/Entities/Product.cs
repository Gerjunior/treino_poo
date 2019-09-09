using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Entities
{
    class Product
    {
        #region Properties
        public string Name { get; set; }
        public double Price { get; set; }
        #endregion

        #region Constructors
        public Product()
        {

        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, {Price}";
        }
        #endregion
    }
}
