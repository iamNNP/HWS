namespace HW3_1
{
    class SingleArray
    {
        private int len = 0;
        private bool init = true;
        private int[] array;

        public SingleArray(int input_len, bool init_input = true)
        {
            len = input_len;
            init = init_input;
            array = new int[len];
        }

        public void CreateArray()
        {
            if (init)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int i = 0; i < len; i++)
                {
                    array[i] = int.Parse(inputs[i]);
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < len; i++)
                {
                    array[i] = rnd.Next(0, 1000);
                }
            }
        }

        public void WriteArray()
        {
            Console.WriteLine("Writing single array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public double Average()
        {
            int counter = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                counter++;
            }
            Console.WriteLine("Counted the average value of the array: ");
            return (double)sum / (double)counter;
        }

        public void ArrayMod100()
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 100 && array[i] >= -100)
                {
                    count++;
                }
            }
            int[] clear_array = new int[count];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 100 && array[i] >= -100)
                {
                    clear_array[count] = array[i];
                    count++;
                }
            }
            array = clear_array;
            Console.WriteLine("All elements higher than 100 were deleted: ");
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
            for (int i = 0; i < array.Length; i++)
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
            Console.WriteLine("All repeating elements were deleted: ");
        }
    }
}