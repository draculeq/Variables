using System;
using Deadbit.Variables.Generic;

namespace Deadbit.Variables.Color.Variable
{
    [Serializable]
    public class ColorVariable : GenericVariable<UnityEngine.Color>
    {
        public ColorVariable(UnityEngine.Color value)
        {
            Value = value;
        }
    }
}