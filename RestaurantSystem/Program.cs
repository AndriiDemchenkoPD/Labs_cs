
namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Встановлення кодування 
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant();

            // 1. Показати меню
            restaurant.Menu.Display();

            // 2. Створення замовлення 1
            Order order101 = restaurant.CreateOrder(5);

            // Пошук страв 
            IMenuItem? item1 = restaurant.Menu.FindItemByName("Борщ");
            IMenuItem? item2 = restaurant.Menu.FindItemByName("Кава");

            order101.AddItem(item1);
            order101.AddItem(item2);

            Console.WriteLine($"Поточна сума замовлення {order101.Id}: {order101.CalculateTotal()} грн");

            // Зміна статусів
            Console.WriteLine($"\nПочатковий статус: {order101.Status}");
            order101.UpdateStatus(OrderStatus.InProgress);
            order101.UpdateStatus(OrderStatus.Ready);
            order101.UpdateStatus(OrderStatus.Paid);

            // 3. Створення замовлення 2
            Console.WriteLine();
            Order order102 = restaurant.CreateOrder(2);
            order102.AddItem(restaurant.Menu.FindItemByName("Деруни"));
            order102.AddItem(restaurant.Menu.FindItemByName("Вино"));

            order102.UpdateStatus(OrderStatus.InProgress);

            // 4. Вивід усіх замовлень
            restaurant.DisplayAllOrders();

            // 5. Демонстрація Downcast 
            Console.WriteLine("\n--- ДЕМОНСТРАЦІЯ DOWNCAST ---");
            IMenuItem someItem = restaurant.Menu.FindItemByName("Сік апельсиновий");

            if (someItem != null)
            {
                // Перевірка через is
                if (someItem is Drink)
                {
                    Drink juice = (Drink)someItem;
                    Console.WriteLine($"Знайдено напій: {juice.Name}");
                    Console.WriteLine($"Об'єм: {juice.VolumeInMl} мл.");
                }
                else
                {
                    Console.WriteLine($"{someItem.Name} - це не напій.");
                }
            }
            Console.WriteLine("-------------------------------");

            // 6. Пошук за категорією MainCourse
            Console.WriteLine("\n--- Пошук за категорією: MainCourse ---");
            List<IMenuItem> mainCourses = restaurant.Menu.FindItemByCategory(ItemCategory.MainCourse);

            foreach (IMenuItem course in mainCourses)
            {
                course.Display();
            }

            Console.ReadLine();
        }
    }
}

