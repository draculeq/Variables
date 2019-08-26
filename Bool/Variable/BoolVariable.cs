using System;
using Deadbit.Variables.Generic;

namespace Deadbit.Variables.Bool.Variable
{
    [Serializable]
    public class BoolVariable : GenericVariable<bool>
    {
        public BoolVariable(bool value)
        {
            Value = value;
        }
    }
}