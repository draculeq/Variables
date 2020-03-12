using Deadbit.Events;
using Deadbit.Variables;
using Sirenix.OdinInspector;
using UnityEngine;

public class FloatMultiply : SerializedMonoBehaviour
{
#pragma warning disable 649
    [SerializeField] private IGenericValue<float> firstValue;
    [SerializeField] private IGenericValue<float> secondValue;
    [SerializeField] private FloatEvent Multiplied;
#pragma warning restore 649

    public void Invoke()
    {
        Multiplied?.Invoke(firstValue.Value * secondValue.Value);
    }
}
