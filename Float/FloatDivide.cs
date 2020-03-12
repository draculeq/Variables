using Deadbit.Events;
using Deadbit.Variables;
using Sirenix.OdinInspector;
using UnityEngine;

public class FloatDivide : SerializedMonoBehaviour
{
#pragma warning disable 649
    [SerializeField] private IGenericValue<float> firstValue;
    [SerializeField] private IGenericValue<float> secondValue;
    [SerializeField] private FloatEvent Divided;
#pragma warning restore 649

    public void Invoke()
    {
        if (Divided != null)
        {
            if (secondValue.Value == 0)
                Divided?.Invoke(float.MaxValue);
            else
                Divided?.Invoke((float)firstValue.Value / secondValue.Value);
        }
    }
}