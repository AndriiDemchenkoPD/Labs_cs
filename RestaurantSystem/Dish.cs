using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Dish: MenuItem
    {
        public ItemCategory Category { get; private set; }
        public Dish(string name, decimal price, ItemCategory category)
            : base(name, price)
        {
            Category = category;
        }

        public override void Display()
        {
            Console.WriteLine($"- {Name} ({Category}) - {Price} грн");
        }
    }
}
