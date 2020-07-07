using Deadbit.Events;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    public class FloatDivide : SerializedMonoBehaviour, IGenericValue<float>
    {
#pragma warning disable 649
        [SerializeField] private IGenericValue<float> dividendValue;
        [SerializeField] private IGenericValue<float> divisorValue;
        [SerializeField] private FloatEvent Divided;
#pragma warning restore 649

        public void Invoke()
        {
            Divided?.Invoke(Value);
        }


        public float Value
        {
            get
            {
                if (Divided != null)
                {
                    if (divisorValue.Value == 0)
                    {
                        Debug.LogWarning("Divisor value is equal 0");
                        return float.MaxValue;
                    }
                    else
                        return dividendValue.Value / divisorValue.Value;
                }

                Debug.LogError("Dividend value is not setup returning 0");
                return 0;
            }
        }
    }
}