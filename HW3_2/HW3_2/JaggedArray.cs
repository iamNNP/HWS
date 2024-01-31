namespace HW3_2
{
    public sealed class JaggedArray : Array
    {
        public int Rows { get; set; }
        private int[][] array;

        public JaggedArray(int rows, string init) : base(rows, init)
        {
            Rows = rows;
            array = new int[rows][];
        }
        public void Create()
        {
            if (base.Init)
            {
                for (int i = 0; i < Rows; i++)
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
                for (int i = 0; i < Rows; i++)
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

        public override void Write()
        {
            Console.WriteLine("Writing jagged array: ");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public override double Average()
        {
            int sum = 0;
            int counter = 0;
            for (int i = 0; i < Rows; i++)
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
    }
}