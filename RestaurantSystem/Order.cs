using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Order
    {
        private static int _nextId = 101;

        public int Id { get; private set; }
        public int TableNumber { get; private set; }
        public OrderStatus Status { get; private set; }

        private List<IMenuItem> _orderedItems = new List<IMenuItem>();

        public Order(int tableNumber)
        {
            Id = _nextId;
            _nextId++; 
            TableNumber = tableNumber;
            Status = OrderStatus.New;
        }

        public void AddItem(IMenuItem item)
        {
            if (item != null)
            {
                _orderedItems.Add(item);
                Console.WriteLine($"Додано позицію до замовлення {Id}: {item.Name}");
            }
            else
            {
                Console.WriteLine("Помилка: страву не знайдено.");
            }
        }

        public void RemoveItem(IMenuItem item)
        {
            if (item != null && _orderedItems.Contains(item))
            {
                _orderedItems.Remove(item);
                Console.WriteLine($"Видалено позицію: {item.Name}");
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (IMenuItem item in _orderedItems)
            {
                total = total + item.Price;
            }
            return total;
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Статус замовлення {Id} оновлено на: {Status}");
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Сума: {CalculateTotal()} грн");
            foreach (var item in _orderedItems)
            {
                Console.Write("    > ");
                item.Display();
            }
        }
    }
}
