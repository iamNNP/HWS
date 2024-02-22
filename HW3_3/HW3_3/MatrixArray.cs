namespace HW3_3
{
    public sealed class MatrixArray : ArrayBase, IMatrixArray
    {
        private int Rows {  get; set; }
        private int Columns { get; set; }
        private int[,] array;
        public MatrixArray(string init, int rows, int columns) : base(init)
        {
            Rows = rows;
            Columns = columns;
            array = new int[rows, columns];
        }

        public override void CreateByUser() {
            for (int i = 0; i < Rows; i++)
            {
                string row = Console.ReadLine();
                string[] array_row = row.Split(' ');
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = int.Parse(array_row[j]);
                }
            }
        }

        public override void CreateByRandom() {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = rnd.Next(1, 100);
                }
            }
        }

        public void Create()
        {
            if (base.Init)
            {
                CreateByUser();
            }
            else
            {
                CreateByRandom();
            }
        }

        public override void Print()
        {
            Console.WriteLine("Printing two-dimensional array: ");
            for (int i = 0; i < Rows; i++)
            {
                string row = "";
                for (int j = 0; j < Columns; j++)
                {
                    row += array[i, j] + " ";
                }
                Console.WriteLine(row);
            }
        }

        public override double Average()
        {
            int sum = 0;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine("Counted the average value of the array: ");
            return (double)sum / (double)(Rows * Columns);
        }

        public void PrintInSnakePattern()
        {
            Console.WriteLine("Printing two-dimensional array in a snake pattern: ");
            for (int i = 0; i < Rows; i++)
            {
                string row = "";
                if (i % 2 == 0)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        row += array[i, j] + " ";
                    }
                }
                else
                {
                    for (int j = Columns - 1; j >= 0; j--)
                    {
                        row += array[i, j] + " ";
                    }
                }
                Console.WriteLine(row);
            }
        }
    }
}