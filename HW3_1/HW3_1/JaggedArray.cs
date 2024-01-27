namespace HW3_1
{
    class JaggedArray
    {
        private int rows = 0;
        private bool init = true;
        private int[][] array;

        public JaggedArray(int input_rows, string init_input="yes")
        {
            rows = input_rows;
            if (init_input == "no") {
                init = false;
            }
            array = new int[rows][];
        }

        public void CreateArray()
        {
            if (init)
            {
                for (int i = 0; i < rows; i++)
                {
                    string row = Console.ReadLine();
                    string[] array_row = row.Split(' ');
                    array[i] = new int[array_row.Length];
                    for (int j = 0; j < array_row.Length; j++)
                    {
                        array[i][j] = int.Parse(array_row[j]);
                    }
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < rows; i++)
                {
                    int array_row_len = rnd.Next(1, 10);
                    array[i] = new int[array_row_len];
                    for (int j = 0; j < array_row_len; j++)
                    {
                        array[i][j] = rnd.Next(1, 100);
                    }
                }
            }
        }

        public void WriteArray()
        {
            Console.WriteLine("Writing jagged array: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public double Average()
        {
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    counter += 1;
                }
            }
            Console.WriteLine("Counted the average value of the array: ");
            return (double)sum / (double)counter;
        }

        public double[] AverageValues()
        {
            double[] average_values = new double[rows];
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                average_values[i] = (double)sum / (double)array[i].Length;
            }
            Console.WriteLine("Counted average values of the array: ");
            return average_values;
        }

        public void ChangeEvenNums()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                }
            }
            Console.WriteLine("All even elements were changed with multiplication of their indices: ");
        }
    }
}