using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables.Setters
{
    class TextureSetter : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private Func<Texture2D> Get;
        [SerializeField] private Action<Texture2D> Set;
#pragma warning restore 649

        public void Invoke()
        {
            Set.Invoke(Get.Invoke());
        }
    }
}