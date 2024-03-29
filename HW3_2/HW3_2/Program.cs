﻿using System;
using System.Diagnostics.SymbolStore;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayBase[] arrays = new ArrayBase[10];
            Random rnd = new Random();
            for (int i = 0; i < arrays.Length; i++)
            {
                int num = rnd.Next(1, 4);
                if (num == 1)
                {
                    SingleArray single_array = new SingleArray("no", rnd.Next(1, 11));
                    single_array.Create();
                    arrays[i] = single_array;
                }
                if (num == 2)
                {
                    int rows = rnd.Next(1, 11);
                    int columns = rnd.Next(1, 11);
                    MatrixArray matrix_array = new MatrixArray("no", rows, columns);
                    matrix_array.Create();
                    arrays[i] = matrix_array;
                }
                if (num == 3)
                {
                    int jagged_rows = rnd.Next(1, 11);
                    JaggedArray jagged_array = new JaggedArray("no", jagged_rows);
                    jagged_array.Create();
                    arrays[i] = jagged_array;
                }
            }
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i].Write();
                Console.WriteLine($"The average is: {arrays[i].Average()}");
            }
        }
    }
}