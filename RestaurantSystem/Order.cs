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

        private readonly List<IMenuItem> _orderedtems = new List<IMenuItem>();

        public Order(int tableNumber)
        {
            Id = _nextId++;
            TableNumber = tableNumber;
            Status = OrderStatus.New;
        }

        public void AddItem(IMenuItem item)
        {
            if (item != null)
            {
                _orderedtems.Add(item);
                Console.WriteLine($"Додано позицію: {item.Name}");
            }
            else
            {
               Console.WriteLine("Позиція не знайдена в меню.");
            }
        }

        public void RemoveItem(IMenuItem item)
        {
            if (item != null && _orderedtems.Contains(item))
            {
                _orderedtems.Remove(item);
                Console.WriteLine($"Видалено позицію: {item.Name}");
            }
            else
            {
                Console.WriteLine("Позиція не знайдена в замовленні.");
            }
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (IMenuItem item in _orderedtems)
            {
                total += item.Price;
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
            foreach (var item in _orderedtems)
            {
                Console.WriteLine($"    > {item.Name} - {item.Price} грн");
            }
        }
    }
}
