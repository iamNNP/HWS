namespace HW3_2
{
    public sealed class SingleArray : Array
    {
        private int[] array;
        public SingleArray(int len, string init) : base(len, init)
        {
            array = new int[base.Len];
        }

        public void Create()
        {
            if (base.Init)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                for (int i = 0; i < base.Len; i++)
                {
                    array[i] = int.Parse(inputs[i]);
                }
            }
            else
            {
                Random rnd = new Random();
                for (int i = 0; i < base.Len; i++)
                {
                    array[i] = rnd.Next(0, 1000);
                }
            }
        }

        public override void Write()
        {
            Console.WriteLine("Writing single array: ");
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
            return (double)sum / (double)(base.Len);
        }
    }
}