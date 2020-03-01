using Deadbit.Events;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    public class StringCompare : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private IGenericValue<string> firstValue;
        [SerializeField] private IGenericValue<string> secondValue;

        [SerializeField, BoxGroup("Events")] private StringEvent onDiffrent;
        [SerializeField, BoxGroup("Events")] private StringEvent onEqual;
#pragma warning restore 649

        [Button(ButtonSizes.Medium)]
        public void Compare()
        {
            if (firstValue.Value == secondValue.Value || (string.IsNullOrEmpty(firstValue.Value) && string.IsNullOrEmpty(secondValue.Value)))
                onEqual.Invoke(firstValue.Value);
            else
                onDiffrent.Invoke(firstValue.Value);
        }

        public void Compare(string comparingValue)
        {
            if (comparingValue == secondValue.Value || (string.IsNullOrEmpty(comparingValue) && string.IsNullOrEmpty(secondValue.Value)))
                onEqual.Invoke(comparingValue);
            else
                onDiffrent.Invoke(comparingValue);
        }
    }
}