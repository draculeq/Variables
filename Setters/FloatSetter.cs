using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables.Setters
{
    class FloatSetter : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private Func<float> Get;
        [SerializeField] private Action<float> Set;
#pragma warning restore 649

        [Button(ButtonSizes.Medium)]
        public void Invoke()
        {
            Set.Invoke(Get.Invoke());
        }
    }
}