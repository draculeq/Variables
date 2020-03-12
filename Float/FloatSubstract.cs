using Deadbit.Events;
using Deadbit.Variables;
using Sirenix.OdinInspector;
using UnityEngine;

public class FloatSubstract : SerializedMonoBehaviour
{
#pragma warning disable 649
    [SerializeField] private IGenericValue<float> firstValue;
    [SerializeField] private IGenericValue<float> secondValue;
    [SerializeField] private FloatEvent Substracted;
#pragma warning restore 649

    public void Invoke()
    {
        Substracted?.Invoke(firstValue.Value - secondValue.Value);
    }

    public void InvokeWithFirstValue(float firstValue)
    {
        Substracted?.Invoke(firstValue - secondValue.Value);
    }

    public void InvokeWithSecondValue(float secondValue)
    {
        Substracted?.Invoke(firstValue.Value - secondValue);
    }
}