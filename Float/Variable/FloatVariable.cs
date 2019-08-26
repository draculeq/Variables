using System;
using Deadbit.Variables.Generic;

namespace Deadbit.Variables.Float.Variable
{
    [Serializable]
    public class FloatVariable : GenericVariable<float>
    {
        public FloatVariable(float value)
        {
            Value = value;
        }
    }
}