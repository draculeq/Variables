using Deadbit.Variables.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;

namespace Deadbit.Variables.String
{
    public class StringCompare : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private IGenericValue<string> firstValue;
        [SerializeField] private IGenericValue<string> secondValue;

        [SerializeField, BoxGroup("Events")]
        private UnityEvent onDiffrent;
        [SerializeField, BoxGroup("Events")]
        private UnityEvent onEqual;
#pragma warning restore 649

        [Button(ButtonSizes.Medium)]
        public void Compare()
        {
            if (firstValue.Value == secondValue.Value || (string.IsNullOrEmpty(firstValue.Value) && string.IsNullOrEmpty(secondValue.Value)))
                onEqual.Invoke();
            else
                onDiffrent.Invoke();
        }
    }
}