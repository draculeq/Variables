using System;

namespace Deadbit.Variables
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