namespace task2
{
    public class Program
    {
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max + 1);
            }
            return array;
        }

        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static double GetAverage(int[] numbers)
        {
            return numbers.Length == 0 ? 0 : (double)GetSum(numbers) / numbers.Length;
        }

        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        static void Main()
        {
            int[] array = GenerateRandomArray(10, 1, 100);

            Console.WriteLine("Згенерований масив:");
            Console.WriteLine(string.Join(", ", array));

            Console.WriteLine($"\nСума: {GetSum(array)}");
            Console.WriteLine($"Середнє: {GetAverage(array):F2}");
            Console.WriteLine($"Мінімум: {GetMin(array)}");
            Console.WriteLine($"Максимум: {GetMax(array)}");
        }
    }
}