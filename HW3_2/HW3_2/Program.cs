using System;
using System.Diagnostics.SymbolStore;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array[] arrays = new Array[14];
            Random rnd = new Random();
            SingleArray first_single_array = new SingleArray(rnd.Next(1, 11), "no");
            first_single_array.Create();
            arrays[0] = first_single_array;
            int first_rows = rnd.Next(1, 11);
            int first_cols = rnd.Next(1, 11);
            MatrixArray first_matrix_array = new MatrixArray(first_rows, first_cols, first_rows * first_cols, "no");
            first_matrix_array.Create();
            arrays[1] = first_matrix_array;
            int first_jagged_rows = rnd.Next(1, 11);
            JaggedArray first_jagged_array = new JaggedArray(first_jagged_rows, "no");
            first_jagged_array.Create();
            arrays[2] = first_jagged_array;
            for (int i = 3; i < arrays.Length; i++)
            {
                int num = rnd.Next(1, 4);
                if (num == 1)
                {
                    SingleArray single_array = new SingleArray(rnd.Next(1, 11), "no");
                    single_array.Create();
                    arrays[i] = single_array;
                }
                if (num == 2)
                {
                    int rows = rnd.Next(1, 11);
                    int columns = rnd.Next(1, 11);
                    MatrixArray matrix_array = new MatrixArray(rows, columns, rows * columns, "no");
                    matrix_array.Create();
                    arrays[i] = matrix_array;
                }
                if (num == 3)
                {
                    int jagged_rows = rnd.Next(1, 11);
                    JaggedArray jagged_array = new JaggedArray(jagged_rows, "no");
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