using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Entities
{
    class OrderItem
    {
        #region Properties
        public int Quantity { get; set; }
        public double Price { get; set; }

        Product Product { get; set; } = new Product();
        #endregion


        #region Constructors
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
        }

        #endregion

        #region Methods

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            
               return Product + ", " + "Quantity: " + Quantity + ", " +  "Subtotal: " + SubTotal();
        }

        #endregion
    }
}
