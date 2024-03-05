namespace HW3_3.Interfaces
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