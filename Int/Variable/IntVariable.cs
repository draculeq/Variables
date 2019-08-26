using System;
using Deadbit.Variables.Generic;

namespace Deadbit.Variables.Int.Variable
{
    [Serializable]
    public class IntVariable : GenericVariable<int>
    {
        public IntVariable(int value)
        {
            Value = value;
        }
    }
}