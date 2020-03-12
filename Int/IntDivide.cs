using Deadbit.Events;
using Deadbit.Variables;
using Sirenix.OdinInspector;
using UnityEngine;

public class IntDivide : SerializedMonoBehaviour
{
#pragma warning disable 649
    [SerializeField] private IGenericValue<int> dividendValue;
    [SerializeField] private IGenericValue<int> divisorValue;
    [SerializeField] private FloatEvent DividedFloat;
    [SerializeField] private IntEvent DividedInt;
#pragma warning restore 649

    public void Invoke()
    {
        if (DividedFloat != null)
        {
            if (divisorValue.Value == 0)
                DividedFloat?.Invoke(float.MaxValue);
            else
                DividedFloat?.Invoke((float)dividendValue.Value / divisorValue.Value);
        }

        if (DividedInt != null)
        {
            if (divisorValue.Value == 0)
                DividedInt.Invoke(int.MaxValue);
            else
                DividedInt.Invoke(dividendValue.Value / divisorValue.Value);
        }
    }
}