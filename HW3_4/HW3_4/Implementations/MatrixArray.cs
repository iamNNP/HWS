namespace HW3_4.Implementations
{
    public sealed class MatrixArray<T> : ArrayBase<T>
    {
        private int Rows {  get; set; }
        private int Columns { get; set; }
        private T[,] array;
        public MatrixArray(string init, int rows, int columns) : base(init)
        {
            Rows = rows;
            Columns = columns;
            array = new T[rows, columns];
        }

        protected override void CreateByUser() {
            for (int i = 0; i < Rows; i++)
            {
                string row = Console.ReadLine();
                string[] array_row = row.Split(' ');
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = type_helper.Convert(array_row[j]);
                }
            }
        }

        protected override void CreateByRandom() {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    array[i, j] = type_helper.GenRandomValue();
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
    }
}