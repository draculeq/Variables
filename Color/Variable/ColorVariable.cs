using System;
using UnityEngine;

namespace Deadbit.Variables
{
    [Serializable]
    public class ColorVariable : GenericVariable<Color>
    {
        public ColorVariable(Color value)
        {
            Value = value;
        }
    }
}