using System;
using System.Diagnostics.SymbolStore;
using HW3_4.Interfaces;
using HW3_4.Implementations;

namespace HW3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter[] arrays = new IPrinter[10];
            Random rnd = new Random();
            for (int i = 0; i < arrays.Length; i++)
            {
                int type_num = rnd.Next(1, 5);
                if (type_num == 1)
                {
                    int num = rnd.Next(0, 3);
                    if (num == 0)
                    {
                        SingleArray<int> single_array = new SingleArray<int>("y", rnd.Next(1, 11));
                        single_array.Create();
                        arrays[i] = single_array;
                    }
                    if (num == 1)
                    {
                        int rows = rnd.Next(1, 11);
                        int columns = rnd.Next(1, 11);
                        MatrixArray<int> matrix_array = new MatrixArray<int>("y", rows, columns);
                        matrix_array.Create();
                        arrays[i] = matrix_array;
                    }
                    if (num == 2)
                    {
                        int jagged_rows = rnd.Next(1, 11);
                        JaggedArray<int> jagged_array = new JaggedArray<int>("y", jagged_rows);
                        jagged_array.Create();
                        arrays[i] = jagged_array;
                    }
                }
                if (type_num == 2)
                {
                    int num = rnd.Next(0, 3);
                    if (num == 0)
                    {
                        SingleArray<double> single_array = new SingleArray<double>("y", rnd.Next(1, 11));
                        single_array.Create();
                        arrays[i] = single_array;
                    }
                    if (num == 1)
                    {
                        int rows = rnd.Next(1, 11);
                        int columns = rnd.Next(1, 11);
                        MatrixArray<double> matrix_array = new MatrixArray<double>("y", rows, columns);
                        matrix_array.Create();
                        arrays[i] = matrix_array;
                    }
                    if (num == 2)
                    {
                        int jagged_rows = rnd.Next(1, 11);
                        JaggedArray<double> jagged_array = new JaggedArray<double>("y", jagged_rows);
                        jagged_array.Create();
                        arrays[i] = jagged_array;
                    }
                }
                if (type_num == 3)
                {
                    int num = rnd.Next(0, 3);
                    if (num == 0)
                    {
                        SingleArray<bool> single_array = new SingleArray<bool>("y", rnd.Next(1, 11));
                        single_array.Create();
                        arrays[i] = single_array;
                    }
                    if (num == 1)
                    {
                        int rows = rnd.Next(1, 11);
                        int columns = rnd.Next(1, 11);
                        MatrixArray<bool> matrix_array = new MatrixArray<bool>("y", rows, columns);
                        matrix_array.Create();
                        arrays[i] = matrix_array;
                    }
                    if (num == 2)
                    {
                        int jagged_rows = rnd.Next(1, 11);
                        JaggedArray<bool> jagged_array = new JaggedArray<bool>("y", jagged_rows);
                        jagged_array.Create();
                        arrays[i] = jagged_array;
                    }
                }
                if (type_num == 4)
                {
                    int num = rnd.Next(0, 3);
                    if (num == 0)
                    {
                        SingleArray<string> single_array = new SingleArray<string>("y", rnd.Next(1, 11));
                        single_array.Create();
                        arrays[i] = single_array;
                    }
                    if (num == 1)
                    {
                        int rows = rnd.Next(1, 11);
                        int columns = rnd.Next(1, 11);
                        MatrixArray<string> matrix_array = new MatrixArray<string>("y", rows, columns);
                        matrix_array.Create();
                        arrays[i] = matrix_array;
                    }
                    if (num == 2)
                    {
                        int jagged_rows = rnd.Next(1, 11);
                        JaggedArray<string> jagged_array = new JaggedArray<string>("y", jagged_rows);
                        jagged_array.Create();
                        arrays[i] = jagged_array;
                    }
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
