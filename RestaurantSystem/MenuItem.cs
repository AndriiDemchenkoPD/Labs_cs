using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public abstract class MenuItem: IMenuItem
    {
        private string _name;
        private decimal _price;

        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            protected set { _price = (value > 0) ? value : 0; }
        }

        protected MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Display();
    }
}
