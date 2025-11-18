using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Menu
    {
        private List<IMenuItem> _items = new List<IMenuItem>();

        public List<IMenuItem> GetItems()
        {
            return _items;
        }

        public void AddItem(IMenuItem item)
        {
            _items.Add(item);
        }

        public void Display()
        {
            Console.WriteLine("--- МЕНЮ РЕСТОРАНУ ---");
            foreach (IMenuItem item in _items)
            {
                item.Display();
            }
            Console.WriteLine("------------------------");
        }

        public IMenuItem? FindItemByName(string name)
        {
            foreach (IMenuItem item in _items)
            {
                if (item.Name == name)
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
