using HW3_4.Interfaces;

namespace HW3_4.Implementations
{
    public abstract class ArrayBase<T> : IArrayBase
    {
        protected static TypeHelper<T> type_helper;
        public bool Init { get; }

        public abstract void Print();

        protected abstract void CreateByRandom();

        protected abstract void CreateByUser();

        public ArrayBase(string init)
        {
            type_helper = new TypeHelper<T>();
            if (init == "N")
            {
                CreateByUser();
            } else {
                CreateByRandom();
            }
        }
    }
}