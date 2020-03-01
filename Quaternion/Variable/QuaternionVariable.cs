using System;
using UnityEngine;

namespace Deadbit.Variables
{
    [Serializable]
    public class QuaternionVariable : GenericVariable<Quaternion>
    {
        public QuaternionVariable(Quaternion value)
        {
            Value = value;
        }
    }
}