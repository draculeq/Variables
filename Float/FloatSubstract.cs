using Deadbit.Events;
using Deadbit.Variables;
using Sirenix.OdinInspector;
using UnityEngine;

public class FloatSubstract : SerializedMonoBehaviour
{
#pragma warning disable 649
    [SerializeField] private IGenericValue<float> minuedValue;
    [SerializeField] private IGenericValue<float> subtrahendValue;
    [SerializeField] private FloatEvent Substracted;
#pragma warning restore 649

    public void Invoke()
    {
        Substracted?.Invoke(minuedValue.Value - subtrahendValue.Value);
    }

    public void InvokeWithMinuedValue(float firstValue)
    {
        Substracted?.Invoke(firstValue - subtrahendValue.Value);
    }

    public void InvokeWithSubtrahendValue(float secondValue)
    {
        Substracted?.Invoke(minuedValue.Value - secondValue);
    }
}