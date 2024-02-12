namespace HW3_2
{
    public abstract class ArrayBase
    {
        protected bool Init { get; set; }

        public abstract void Write();

        public abstract double Average();

        protected abstract void CreateByRandom();

        protected abstract void CreateByUser();

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