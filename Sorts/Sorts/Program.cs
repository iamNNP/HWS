using System;

namespace Sorts
{
    class Arrays
    {
        public double[] InitArray(int n)
        {
            double[] array = new double[n];
            string input = Console.ReadLine();
            string[] inputs = input.Split();
            for (int i = 0; i < inputs.Length; i++)
            {
                array[i] = int.Parse(inputs[i]);
            }
            return array;
        }
        public double[] GenerateRandomArray(int n, int min, int max)
        {
            double[] array = new double[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            return array;
        }
        public void WriteArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
    class Sorts
    {
        public int CountLowerPivot(double[] array, double pivot)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < pivot) { count++; }
            }
            return count;
        }
        public int CountEqualPivot(double[] array, double pivot)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == pivot) { count++; }
            }
            return count;
        }
        public int CountHigherPivot(double[] array, double pivot)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > pivot) { count++; }
            }
            return count;
        }
        public double[] QuickSort(double[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }
            double pivot = array[0];
            double[] lower = new double[CountLowerPivot(array, pivot)];
            double[] equal = new double[CountEqualPivot(array, pivot)];
            double[] higher = new double[CountHigherPivot(array, pivot)];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < pivot)
                {
                    lower[count] = array[i];
                    count++;
                }
            }
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == pivot)
                {
                    equal[count] = array[i];
                    count++;
                }
            }
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > pivot)
                {
                    higher[count] = array[i];
                    count++;
                }
            }
            double[] sorted_array = new double[array.Length];
            double[] sorted_lower = QuickSort(lower);
            double[] sorted_higher = QuickSort(higher);
            for (int i = 0; i < sorted_array.Length; i++)
            {
                if (i < lower.Length)
                {
                    sorted_array[i] = sorted_lower[i];
                } else if (i < (lower.Length + equal.Length)) {
                    sorted_array[i] = equal[i - lower.Length];
                } else
                {
                    sorted_array[i] = sorted_higher[i - lower.Length - equal.Length];
                }
            }
            return sorted_array;
        }
        public int FindMaxIndex(double[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            return max;
        }
        public void Swap(ref double[] array, int first_index, int second_index)
        {
            double temp = array[first_index];
            array[first_index] = array[second_index];
            array[second_index] = temp;
        }
        public double[] MaxSort(double[] array)
        {
            for (int i = array.Length - 1; i>= 1; i--)
            {
                double[] subarray = new double[i+1];
                Array.Copy(array, 0, subarray, 0, i + 1);
                int max_index = FindMaxIndex(subarray);
                double max = array[max_index];
                Swap(ref array, i, max_index);
            }
            return array;
        }
        public double[] BubbleSort(double[] array)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        double temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Arrays A = new Arrays();
            Console.Write("Input the length of the array: ");
            int n = int.Parse(Console.ReadLine());
            //double[] array = A.InitArray(n);
            Console.Write("Input min value for random generation: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Input max value for random generation: ");
            int max = int.Parse(Console.ReadLine());
            double[] array = A.GenerateRandomArray(n, min, max);
            A.WriteArray(array);
            Sorts S = new Sorts();
            var Watch = System.Diagnostics.Stopwatch.StartNew();
            double[] quick_sorted_array = S.QuickSort(array);
            Watch.Stop();
            long quick_sort_time = Watch.ElapsedMilliseconds;

            Watch.Restart();
            double[] max_sorted_array = S.MaxSort(array);
            Watch.Stop();
            long max_sort_time = Watch.ElapsedMilliseconds;

            Watch.Restart();
            double[] bubble_sorted_array = S.BubbleSort(array);
            Watch.Stop();
            long bubble_sort_time = Watch.ElapsedMilliseconds;
            A.WriteArray(quick_sorted_array);
            Console.WriteLine($"Time for QuickSort: {quick_sort_time} ms");
            Console.WriteLine($"Time for MaxSort: {max_sort_time} ms");
            Console.WriteLine($"Time for BubbleSort: {bubble_sort_time} ms");
            Console.ReadKey();
        }
    }
}