using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Restaurant
    {
        public Menu Menu { get; private set; }

        private List<Order> _activeOrders = new List<Order>();

        public Restaurant()
        {
            Menu = new Menu();
            InitializeMenu(); 
        }

        private void InitializeMenu()
        {
            Menu.AddItem(new Dish("Борщ", 120.50m, ItemCategory.FirstCourse));
            Menu.AddItem(new Dish("Деруни", 150.00m, ItemCategory.MainCourse));
            Menu.AddItem(new Dish("Наполеон", 95.00m, ItemCategory.Dessert));

            Menu.AddItem(new Drink("Кава", 60.00m, 200, false));
            Menu.AddItem(new Drink("Сік апельсиновий", 70.00m, 250, false));
            Menu.AddItem(new Drink("Вино", 110.00m, 150, true));
        }

        public Order CreateOrder(int tableNumber)
        {
            Order newOrder = new Order(tableNumber);
            _activeOrders.Add(newOrder);
            Console.WriteLine($"Створено нове замовлення {newOrder.Id} для столика №{tableNumber}");
            return newOrder;
        }

        public void DisplayAllOrders()
        {
            Console.WriteLine("\n--- УСІ АКТИВНІ ЗАМОВЛЕННЯ ---");
            if (_activeOrders.Count == 0)
            {
                Console.WriteLine("Активних замовлень немає.");
                return;
            }

            foreach (var order in _activeOrders)
            {
                order.Display();
            }
            Console.WriteLine("-------------------------------");
        }

        public Order? FindOrderById(int id)
        {
            foreach (Order order in _activeOrders)
            {
                if (order.Id == id)
                {
                    return order; 
                }
            }
            return null; 
        }
    }
}
