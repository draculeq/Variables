using System;
using Deadbit.Variables.Generic;

namespace Deadbit.Variables.Sprite.Variable
{
    [Serializable]
    public class SpriteVariable : GenericVariable<UnityEngine.Sprite>
    {
        public SpriteVariable(UnityEngine.Sprite value)
        {
            Value = value;
        }
    }
}