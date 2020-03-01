namespace Deadbit.Variables
{
    public interface IGenericVariable<T> : IGenericValue<T>
    {
        new T Value { get; set; }
    }
}