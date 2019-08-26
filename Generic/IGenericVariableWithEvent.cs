using UnityEngine.Events;

namespace Deadbit.Variables.Generic
{
    interface IGenericVariableWithEvent<T> : IGenericVariable<T>
    {
        UnityEvent<T> ValueChanged { get; }
    }
}
