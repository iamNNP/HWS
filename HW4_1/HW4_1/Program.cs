using System;
using System.Diagnostics.SymbolStore;
using HW3_4.Implementations;

namespace HW3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            SingleArray<int> single_array = new SingleArray<int>(0);
            for (int i = 0; i < 11; i++)
            {
                single_array.Add(rnd.Next(1, 100));
            }
            Console.Write("Int single array: ");
            single_array.ForEach((x) => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine($"Min: {single_array.Min()}");
            Console.WriteLine($"Max: {single_array.Max()}");
            Console.Write("Sorted array: ");
            single_array.Sort();
            single_array.ForEach((x) => Console.Write(x + " "));
            Console.WriteLine();

            SingleArray<double> single_array1 = new SingleArray<double>(0);
            for (int i = 0; i < 11; i++)
            {
                double to_add = rnd.Next(1, 100) + rnd.NextDouble();
                single_array1.Add(to_add);
            }
            Console.Write("Double single array: ");
            single_array1.ForEach((x) => Console.Write(x + " "));
            Console.WriteLine();
            Console.WriteLine($"Min: {single_array1.Min()}");
            Console.WriteLine($"Max: {single_array1.Max()}");
            Console.Write("Sorted array: ");
            single_array1.Sort();
            single_array1.ForEach((x) => Console.Write(x + " "));
            Console.WriteLine();
            Console.Write("Press enter to exit: ");
            Console.ReadLine();
        }
    }
}
