using Deadbit.Events;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    public class BoolCheck : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private IGenericValue<bool> boolGiver;

        [SerializeField, BoxGroup("Events")] private BoolEvent isTrue;
        [SerializeField, BoxGroup("Events")] private BoolEvent isFalse;
#pragma warning restore 649

        public void Check()
        {
            if (boolGiver == null)
            {
                Debug.LogError("Getter is null!");
                return;
            }

            if (boolGiver.Value)
            {
                isTrue.Invoke(boolGiver.Value);
            }
            else
            {
                isFalse.Invoke(boolGiver.Value);
            }
        }

        public void Check(bool value)
        {
            if (value)
            {
                isTrue.Invoke(value);
            }
            else
            {
                isFalse.Invoke(value);
            }
        }
    }
}