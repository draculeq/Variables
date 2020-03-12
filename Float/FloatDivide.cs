using Deadbit.Events;
using Deadbit.Variables;
using Sirenix.OdinInspector;
using UnityEngine;

public class FloatDivide : SerializedMonoBehaviour
{
#pragma warning disable 649
    [SerializeField] private IGenericValue<float> dividendValue;
    [SerializeField] private IGenericValue<float> divisorValue;
    [SerializeField] private FloatEvent Divided;
#pragma warning restore 649

    public void Invoke()
    {
        if (Divided != null)
        {
            if (divisorValue.Value == 0)
                Divided?.Invoke(float.MaxValue);
            else
                Divided?.Invoke((float)dividendValue.Value / divisorValue.Value);
        }
    }
}