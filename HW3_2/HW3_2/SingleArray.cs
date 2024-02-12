namespace HW3_2
{
    public sealed class SingleArray : ArrayBase
    {
        private int Len { get; set; }
        private int[] array;
        public SingleArray(string init, int len) : base(init)
        {
            Len = len;
            array = new int[len];
        }

        protected override void CreateByUser() {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < Len; i++)
            {
                array[i] = int.Parse(inputs[i]);
            }
        }

        protected override void CreateByRandom() {
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
            return (double)sum / (double)(Len);
        }
    }
}