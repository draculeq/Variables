using Deadbit.Events;
using Deadbit.Variables;
using Sirenix.OdinInspector;
using UnityEngine;

public class IntDivide : SerializedMonoBehaviour
{
#pragma warning disable 649
    [SerializeField] private IGenericValue<int> firstValue;
    [SerializeField] private IGenericValue<int> secondValue;
    [SerializeField] private FloatEvent DividedFloat;
    [SerializeField] private IntEvent DividedInt;
#pragma warning restore 649

    public void Invoke()
    {
        if (DividedFloat != null)
        {
            if (secondValue.Value == 0)
                DividedFloat?.Invoke(float.MaxValue);
            else
                DividedFloat?.Invoke((float)firstValue.Value / secondValue.Value);
        }

        if (DividedInt != null)
        {
            if (secondValue.Value == 0)
                DividedInt.Invoke(int.MaxValue);
            else
                DividedInt.Invoke(firstValue.Value / secondValue.Value);
        }
    }
}