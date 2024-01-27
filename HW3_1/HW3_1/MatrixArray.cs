namespace HW3_1
{
    class MatrixArray
    {
        private int rows = 0;
        private int columns = 0;
        private bool init = true;
        private int[,] array;

        public MatrixArray(int input_rows, int input_columns, string input_init="yes")
        {
            rows = input_rows;
            columns = input_columns;
            if (input_init == "no") {
                init = false;
            }
            array = new int[rows, columns];
        }

        public void CreateArray()
        {
            if (init)
            {
                for (int i = 0; i < rows; i++)
                {
                    string row = Console.ReadLine();
                    string[] array_row = row.Split(' ');
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = int.Parse(array_row[j]);
                    }
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        array[i, j] = rnd.Next(1, 100);
                    }
                }
            }
        }

        public void WriteArray()
        {
            Console.WriteLine("Writing two-dimensional array: ");
            for (int i = 0; i < rows; i++)
            {
                string row = "";
                for (int j = 0; j < columns; j++)
                {
                    row += array[i, j] + " ";
                }
                Console.WriteLine(row);
            }
            Console.WriteLine("Writing two-dimensional array in a snake pattern: ");
            for (int i = 0; i < rows; i++)
            {
                string row = "";
                if (i % 2 == 0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        row += array[i, j] + " ";
                    }
                }
                else
                {
                    for (int j = columns - 1; j >= 0; j--)
                    {
                        row += array[i, j] + " ";
                    }
                }
                Console.WriteLine(row);
            }
        }

        public double Average()
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine("Counted the average value of the array: ");
            return (double)sum / (double)(rows * columns);
        }
    }
}