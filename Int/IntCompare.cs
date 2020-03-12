using Deadbit.Variables;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

public class IntCompare : SerializedMonoBehaviour
{
#pragma warning disable 0649
    [SerializeField] private IGenericValue<int> firstValue;
    [SerializeField] private IGenericValue<int> secondValue;

    [SerializeField, BoxGroup("Events")] private UnityEvent firstBigger;
    [SerializeField, BoxGroup("Events")] private UnityEvent equal;
    [SerializeField, BoxGroup("Events")] private UnityEvent secondBigger;
#pragma warning restore 0649

    [Button(ButtonSizes.Medium)]
    public void Compare()
    {
        if (firstValue.Value == secondValue.Value)
            equal.Invoke();
        else if (firstValue.Value > secondValue.Value)
            firstBigger.Invoke();
        else if (firstValue.Value < secondValue.Value)
            secondBigger.Invoke();
    }


    [Button(ButtonSizes.Medium)]
    public void CompareWithFirstValue(int firstValue)
    {
        if (firstValue == secondValue.Value)
            equal.Invoke();
        else if (firstValue > secondValue.Value)
            firstBigger.Invoke();
        else if (firstValue < secondValue.Value)
            secondBigger.Invoke();
    }
}