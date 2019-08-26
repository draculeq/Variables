using System;
using UnityEngine;

namespace Deadbit.Variables.Generic
{
    [Serializable]
    public class GenericFunctionToVariable<T> : IGenericValue<T>, IGenericVariable<Func<T>>
    {
        [SerializeField]
        private Func<T> Function;

        public T Value => Function != null ? Function() : default(T);

        Func<T> IGenericVariable<Func<T>>.Value
        {
            get => Function;
            set
            {
                if (Function == null)
                    return;
                Function = value;
            }
        }

        Func<T> IGenericValue<Func<T>>.Value => Function;
    }
}