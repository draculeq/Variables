using System;

namespace Deadbit.Variables
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