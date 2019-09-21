using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables.Setters
{
    class SpriteSetter : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private Func<UnityEngine.Sprite> Get;
        [SerializeField] private Action<UnityEngine.Sprite> Set;
#pragma warning restore 649

        [Button(ButtonSizes.Medium)]
        public void Invoke()
        {
            Set.Invoke(Get.Invoke());
        }
    }
}