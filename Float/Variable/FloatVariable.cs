using System;

namespace Deadbit.Variables
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