using Deadbit.Events;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    public class IntMultiply : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private IGenericValue<int> firstFactor;
        [SerializeField] private IGenericValue<int> secondFactor;
        [SerializeField] private FloatEvent ProductFloat;
        [SerializeField] private IntEvent ProductInt;
#pragma warning restore 649

        public void Invoke()
        {
            if (ProductFloat != null)
            {
                ProductFloat?.Invoke((float) firstFactor.Value * secondFactor.Value);
            }

            if (ProductInt != null)
            {
                ProductInt.Invoke(firstFactor.Value * secondFactor.Value);
            }
        }

        public void Invoke(int secondFactor)
        {
            if (ProductFloat != null)
            {
                ProductFloat?.Invoke((float) firstFactor.Value * secondFactor);
            }

            if (ProductInt != null)
            {
                ProductInt.Invoke(firstFactor.Value * secondFactor);
            }
        }
    }
}