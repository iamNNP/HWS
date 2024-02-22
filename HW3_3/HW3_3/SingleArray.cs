namespace HW3_3
{
    public sealed class SingleArray : ArrayBase, ISingleArray
    {
        private int Len { get; set; }
        private int[] array;
        public SingleArray(string init, int len) : base(init)
        {
            Len = len;
            array = new int[len];
        }

        public override void CreateByUser() {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < Len; i++)
            {
                array[i] = int.Parse(inputs[i]);
            }
        }

        public override void CreateByRandom() {
            Random rnd = new Random();
            for (int i = 0; i < Len; i++)
            {
                array[i] = rnd.Next(0, 1000);
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
            Console.WriteLine("Printing single array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public override double Average()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Counted the average value of the array: ");
            return (double)sum / (double)(Len);
        }

        private bool ContainsStopIndex(int[] array, int element, int stop_index)
        {
            for (int i = 0; i < stop_index; i++)
            {
                if (array[i] == element)
                {
                    return true;
                }
            }
            return false;
        }

        public void ClearArray()
        {
            int[] clear_array = new int[array.Length];
            int count = 0;
            for (int i = 0; i < Len; i++)
            {
                if (!(ContainsStopIndex(clear_array, array[i], count)))
                {
                    clear_array[count] = array[i];
                    count++;
                }
            }
            int[] clear_array_result = new int[count];
            Array.Copy(clear_array, 0, clear_array_result, 0, count);
            array = clear_array_result;
            Console.WriteLine("All repeated elements were deleted from the array");
        }
    }
}