using Deadbit.Events;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    public class IntAdd : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private IGenericValue<int> firstIngredient;
        [SerializeField] private IGenericValue<int> secondIngredient;
        [SerializeField] private FloatEvent SumFloat;
        [SerializeField] private IntEvent SumInt;
#pragma warning restore 649

        public void Invoke()
        {
            if (SumFloat != null)
            {
                SumFloat?.Invoke((float) firstIngredient.Value + secondIngredient.Value);
            }

            if (SumInt != null)
            {
                SumInt.Invoke(firstIngredient.Value + secondIngredient.Value);
            }
        }

        public void Invoke(int secondIngredient)
        {
            if (SumFloat != null)
            {
                SumFloat?.Invoke((float) firstIngredient.Value + secondIngredient);
            }

            if (SumInt != null)
            {
                SumInt.Invoke(firstIngredient.Value + secondIngredient);
            }
        }
    }
}