using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables.Setters
{
    class IntSetter : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private Func<int> Get;
        [SerializeField] private Action<int> Set;
#pragma warning restore 649

        [Button(ButtonSizes.Medium)]
        public void Invoke()
        {
            Set.Invoke(Get.Invoke());
        }
    }
}
