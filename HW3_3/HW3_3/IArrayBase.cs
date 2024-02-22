namespace HW3_3
{
    public interface IArrayBase : IPrinter
    {
        bool Init { get; }

        void Print();

        double Average();

        void CreateByRandom();

        void CreateByUser();
    }
}