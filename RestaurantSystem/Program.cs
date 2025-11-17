
namespace RestaurantSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();

            restaurant.Menu.Display();

            Order order101 = restaurant.CreateOrder(5);

            IMenuItem? borshch = restaurant.Menu.FindItemByName("Борщ", restaurant.Menu.Items.ToList());
            IMenuItem? kava = restaurant.Menu.FindItemByName("Кава", restaurant.Menu.Items.ToList());

            order101.AddItem(borshch);
            order101.AddItem(kava);

            Console.WriteLine($"Поточна сума замовлення {order101.Id}: {order101.CalculateTotal()} грн");

            Console.WriteLine($"\nСтатус замовлення: {order101.Status}");
            order101.UpdateStatus(OrderStatus.InProgress);
            order101.UpdateStatus(OrderStatus.Ready);
            order101.UpdateStatus(OrderStatus.Paid);

            Order order102 = restaurant.CreateOrder(2);
            order102.AddItem(restaurant.Menu.FindItemByName("Деруни", restaurant.Menu.Items.ToList()));
            order102.AddItem(restaurant.Menu.FindItemByName("Вино", restaurant.Menu.Items.ToList()));
            order102.UpdateStatus(OrderStatus.InProgress);

            restaurant.DisplayAllOrders();

            Console.WriteLine("\n--- ДЕМОНСТРАЦІЯ DOWNCAST ---");
            IMenuItem? item = restaurant.Menu.FindItemByName("Сік апельсиновий", restaurant.Menu.Items.ToList());

            if (item != null)
            {
                if (item is Drink)
                {
                    Drink juice = (Drink)item;
                    Console.WriteLine($"Успішне приведення: {juice.Name}");
                    Console.WriteLine($"Це напій об'ємом {juice.VolumeInMl} мл.");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - це не напій.");
                }
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("\n--- Пошук за категорією: MainCourse ---");
            List<IMenuItem> mainCourses = restaurant.Menu.FindItemByCategory(ItemCategory.MainCourse);
            foreach (IMenuItem course in mainCourses)
            {
                course.Display();
            }

            
        }
    }
}

