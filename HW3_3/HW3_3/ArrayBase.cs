namespace HW3_3
{
    public abstract class ArrayBase : IArrayBase
    {
        public bool Init { get; set; }

        public abstract void Print();

        public abstract double Average();

        public abstract void CreateByRandom();

        public abstract void CreateByUser();

        public ArrayBase(string init)
        {
            Init = true;
            if (init == "no")
            {
                Init = false;
            }
        }
    }
}