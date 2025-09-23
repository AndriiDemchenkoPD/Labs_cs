namespace Task5
{
    using System;

    public class Program
    {
        public static double GetAverage(int[] marks)
        {
            if (marks.Length == 0) return 0;
            int sum = 0;
            foreach (int mark in marks)
                sum += mark;
            return (double)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
                if (mark < min)
                    min = mark;
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
                if (mark > max)
                    max = mark;
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int[] group = groups[i];
                double avg = GetAverage(group);
                int min = GetMin(group);
                int max = GetMax(group);

                Console.WriteLine($"Група {i + 1}: Середній = {Math.Round(avg)}, Мінімальний = {min}, Максимальний = {max}");
            }
        }

        static void Main()
        {
            int[][] groups = new int[][]
            {
            new int[] { 80, 90, 100, 75, 60, 85, 95, 70, 88, 92 },
            new int[] { 65, 70, 55, 80, 95, 50, 60, 75, 85, 70, 68 },
            new int[] { 100, 98, 95, 96, 94, 97, 99, 100, 90, 92 }
            };

            PrintGroupStatistics(groups);

        }
    }

}