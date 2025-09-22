namespace task4
{
    internal class Program
    {
        static bool IsValidTriangle(double a, double b, double c)
        {
            return a > 0 && b > 0 && c > 0 &&
                   a + b > c && a + c > b && b + c > a;
        }

        static double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }

        static double GetArea(double a, double b, double c)
        {
            double s = GetPerimeter(a, b, c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
                return "Рівносторонній";

            if (a == b || b == c || a == c)
                return "Рівнобедрений";

            double a2 = a * a, b2 = b * b, c2 = c * c;
            if (Math.Abs(a2 + b2 - c2) < 1e-6 ||
                Math.Abs(a2 + c2 - b2) < 1e-6 ||
                Math.Abs(b2 + c2 - a2) < 1e-6)
                return "Прямокутний";

            return "Довільний";
        }

        static void Main()
        {
            Console.Write("Введіть сторону a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введіть сторону c: ");
            double c = double.Parse(Console.ReadLine());

            if (IsValidTriangle(a, b, c))
            {
                Console.WriteLine("\nТрикутник існує.");
                Console.WriteLine($"Периметр: {GetPerimeter(a, b, c):F2}");
                Console.WriteLine($"Площа: {GetArea(a, b, c):F2}");
                Console.WriteLine($"Тип: {GetTriangleType(a, b, c)}");
            }
            else
            {
                Console.WriteLine("\nТрикутник не існує або сторони некоректні.");
            }
        }
    }
}