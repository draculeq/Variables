using UnityEngine.Events;

namespace Deadbit.Variables
{
    interface IGenericVariableWithEvent<T> : IGenericVariable<T>
    {
        UnityEvent<T> ValueChanged { get; }
    }
}
