namespace HW3_4.Implementations
{
    public sealed class SingleArray<T> : ArrayBase<T>
    {
        private int Len { get; set; }
        private T[] array;
        public SingleArray(string init, int len) : base(init)
        {
            Len = len;
            array = new T[len];
        }

        protected override void CreateByUser() {
            string[] inputs = Console.ReadLine().Split(' ');
            for (int i = 0; i < Len; i++)
            {
                array[i] = type_helper.Convert(inputs[i]);
            }
        }

        protected override void CreateByRandom() {
            Random rnd = new Random();
            for (int i = 0; i < Len; i++)
            {
                array[i] = type_helper.GenRandomValue();
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
    }
}