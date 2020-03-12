using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Variables
{
    public class FloatCompare : SerializedMonoBehaviour
    {
#pragma warning disable 0649
        [SerializeField] private IGenericValue<float> firstValue;
        [SerializeField] private IGenericValue<float> secondValue;

        [SerializeField] private float tolerance = 0.001f;

        [SerializeField, BoxGroup("Events")] private UnityEvent firstBigger;
        [SerializeField, BoxGroup("Events")] private UnityEvent equal;
        [SerializeField, BoxGroup("Events")] private UnityEvent secondBigger;
#pragma warning restore 0649

        [Button(ButtonSizes.Medium)]
        public void Compare()
        {
            if (Mathf.Abs(firstValue.Value - secondValue.Value) < tolerance)
                equal.Invoke();
            else if (firstValue.Value > secondValue.Value)
                firstBigger.Invoke();
            else if (firstValue.Value < secondValue.Value)
                secondBigger.Invoke();
        }


        [Button(ButtonSizes.Medium)]
        public void CompareWithFirstValue(float firstValue)
        {
            if (Mathf.Abs(firstValue - secondValue.Value) < tolerance)
                equal.Invoke();
            else if (firstValue > secondValue.Value)
                firstBigger.Invoke();
            else if (firstValue < secondValue.Value)
                secondBigger.Invoke();
        }
    }
}