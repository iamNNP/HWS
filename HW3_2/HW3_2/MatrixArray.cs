namespace HW3_2
{
    public sealed class MatrixArray : Array
    {
        public int Rows {  get; set; }
        public int Columns { get; set; }
        private int[,] array;
        
        public MatrixArray(int rows, int columns, int len, string init) : base(len, init)
        {
            Rows = rows;
            Columns = columns;
            array = new int[rows, columns];
        }

        public void Create()
        {
            if (base.Init)
            {
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
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        array[i, j] = rnd.Next(1, 100);
                    }
                }
            }
        }

        public override void Write()
        {
            Console.WriteLine("Writing two-dimensional array: ");
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
            return (double)sum / (double)(base.Len);
        }
    }
}