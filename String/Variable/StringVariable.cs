using System;
using Deadbit.Variables.Generic;

namespace Deadbit.Variables.String.Variable
{
    [Serializable]
    public class StringVariable : GenericVariable<string>
    {
        public StringVariable(string value)
        {
            Value = value;
        }
    }
}