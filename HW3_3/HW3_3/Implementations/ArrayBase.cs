using HW3_3.Interfaces;

namespace HW3_3.Implementations
{
    public abstract class ArrayBase : IArrayBase
    {
        public bool Init { get; }

        public abstract void Print();

        public abstract double Average();

        protected abstract void CreateByRandom();

        protected abstract void CreateByUser();

        public ArrayBase(string init)
        {
            if (init == "N")
            {
                CreateByUser();
            } else {
                CreateByRandom();
            }
        }
    }
}