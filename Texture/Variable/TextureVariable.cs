using System;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.Texture.Variable
{
    [Serializable]
    public class TextureVariable : GenericVariable<Texture2D>
    {
        public TextureVariable(Texture2D value)
        {
            Value = value;
        }
    }
}