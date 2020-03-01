using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Deadbit.Variables
{
    public class TextStyle : SerializedMonoBehaviour
    {
#pragma warning disable 649
        [SerializeField] private IGenericValue<string> getter;
        [SerializeField] private IGenericValue<string> styleName;
        [SerializeField] private Action<string> setter;
#pragma warning restore 649

        [Button(ButtonSizes.Medium)]
        public void AddStyle()
        {
            if (styleName == null || string.IsNullOrEmpty(styleName.Value))
                setter.Invoke(getter.Value);
            else
                setter.Invoke($"<style={styleName.Value}>{getter.Value}</style>");
        }

        public void InvokeWithValue(string value)
        {
            if (styleName == null || string.IsNullOrEmpty(styleName.Value))
                setter.Invoke(value);
            else
                setter.Invoke($"<style={styleName.Value}>{value}</style>");
        }

        public void InvokeWithStyle(string style)
        {
            if (string.IsNullOrEmpty(style))
                setter.Invoke(getter.Value);
            else
                setter.Invoke($"<style={style}>{getter.Value}</style>");
        }
    }
}