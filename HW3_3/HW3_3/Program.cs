using System;
using System.Diagnostics.SymbolStore;
using HW3_3.Interfaces;
using HW3_3.Implementations;

namespace HW3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter[] arrays = new IPrinter[10];
            Random rnd = new Random();
            for (int i = 0; i < arrays.Length; i++)
            {
                int num = rnd.Next(1, 5);
                if (num == 1)
                {
                    SingleArray single_array = new SingleArray("y", rnd.Next(1, 11));
                    single_array.Create();
                    arrays[i] = single_array;
                }
                if (num == 2)
                {
                    int rows = rnd.Next(1, 11);
                    int columns = rnd.Next(1, 11);
                    MatrixArray matrix_array = new MatrixArray("y", rows, columns);
                    matrix_array.Create();
                    arrays[i] = matrix_array;
                }
                if (num == 3)
                {
                    int jagged_rows = rnd.Next(1, 11);
                    JaggedArray jagged_array = new JaggedArray("y", jagged_rows);
                    jagged_array.Create();
                    arrays[i] = jagged_array;
                }
                if (num == 4)
                {
                    WeekDays week_days = new WeekDays();
                    arrays[i] = week_days;
                }
            }
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i].Print();
            }
            Console.Write("Press enter to exit: ");
            Console.ReadLine();
        }
    }
}