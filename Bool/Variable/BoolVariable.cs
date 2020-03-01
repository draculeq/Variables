using System;

namespace Deadbit.Variables
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