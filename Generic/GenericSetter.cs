using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    class GenericSetter<T> : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private Func<T> Get;
        [SerializeField] private Action<T> Set;
#pragma warning restore 649

        [Button(ButtonSizes.Medium)]
        public void Invoke()
        {
            Set.Invoke(Get.Invoke());
        }
    }
}