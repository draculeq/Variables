using System;
using UnityEngine;

namespace Deadbit.Variables
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