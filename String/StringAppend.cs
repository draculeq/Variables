using System.Collections.Generic;
using System.Text;
using Deadbit.Events;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    public class StringAppend : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private List<IGenericValue<string>> values;

        [SerializeField, BoxGroup("Events")] private StringEvent Appended;
#pragma warning restore 649

        [Button(ButtonSizes.Medium)]
        public void Invoke()
        {
            var stringBuilder = new StringBuilder();
            foreach (var value in values) stringBuilder.Append(value.Value);

            var result = stringBuilder.ToString();
            Appended?.Invoke(result);
        }
    }
}