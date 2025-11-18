using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public abstract class MenuItem : IMenuItem
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }

        protected MenuItem(string name, decimal price)
        {
            Name = name;
            if (price > 0)
                Price = price;
            else
                Price = 0;
        }

        public abstract void Display();
    }
}
