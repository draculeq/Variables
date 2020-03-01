using System;
using UnityEngine;

namespace Deadbit.Variables
{
    [Serializable]
    public class SpriteVariable : GenericVariable<Sprite>
    {
        public SpriteVariable(Sprite value)
        {
            Value = value;
        }
    }
}