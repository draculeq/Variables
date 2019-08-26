namespace Deadbit.Variables.Generic
{
    public interface IGenericVariable<T> : IGenericValue<T>
    {
        new T Value { get; set; }
    }
}