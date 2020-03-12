using Deadbit.Events;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    public class FloatMultiply : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private IGenericValue<float> firstMultiplierValue;
        [SerializeField] private IGenericValue<float> secondMultiplierValue;
        [SerializeField] private FloatEvent Multiplied;
#pragma warning restore 649

        public void Invoke()
        {
            Multiplied?.Invoke(firstMultiplierValue.Value * secondMultiplierValue.Value);
        }
    }
}