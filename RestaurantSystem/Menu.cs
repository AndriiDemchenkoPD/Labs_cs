using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Menu
    {
        private readonly List<IMenuItem> _items = new List<IMenuItem>();

        public IReadOnlyList<IMenuItem> Items => _items.AsReadOnly();

        public void AddItem(IMenuItem item)
        {
            _items.Add(item);
        }

        public void Display()
        {
            Console.WriteLine("--- МЕНЮ РЕСТОРАНУ ---");
            foreach (var item in _items)
            {
                item.Display();
            }
            Console.WriteLine("------------------------");
        }
        public IMenuItem? FindItemByName(string name, List<IMenuItem> items)
        {
            foreach (var item in items)
            {
                if (item.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }
            return null;
        }

        public List<IMenuItem> FindItemByCategory(ItemCategory category)
        {
            List<IMenuItem> foundItems = new List<IMenuItem>();
            foreach (IMenuItem item in _items)
            {
                if (item is Dish)
                {
                    Dish dish = (Dish)item;
                    if (dish.Category == category)
                    {
                        foundItems.Add(dish);
                    }
                }
            }
            return foundItems;
        }
    }
}
