using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables.Setters
{
    class StringSetter : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private Func<string> Get;
        [SerializeField] private Action<string> Set;
#pragma warning restore 649

        public void Invoke()
        {
            Set.Invoke(Get.Invoke());
        }
    }
}