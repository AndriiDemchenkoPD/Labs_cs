namespace task1
{
    public class Program
    {
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static string GetMessage(int number)
        {
            return IsEven(number) ? "Двері відкриваються!" : "Двері зачинені...";
        }

        public static void Main()
        {
            Console.Write("Введіть число: ");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                string message = GetMessage(input);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Некоректне введення. Спробуйте ще раз.");
            }
        }

    }
}