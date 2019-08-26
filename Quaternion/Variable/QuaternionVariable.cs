using System;
using Deadbit.Variables.Generic;

namespace Deadbit.Variables.Quaternion.Variable
{
    [Serializable]
    public class QuaternionVariable : GenericVariable<UnityEngine.Quaternion>
    {
        public QuaternionVariable(UnityEngine.Quaternion value)
        {
            Value = value;
        }
    }
}