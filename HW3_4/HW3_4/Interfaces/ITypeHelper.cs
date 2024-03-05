namespace HW3_4.Interfaces
{
    public interface ITypeHelper<T>
    {
        T Convert();
        int GenRandomInt();
        string GenRandomString();
        bool GenRandomBool();
        double GenRandomDouble();
        T GenRandomValue();
    }
}