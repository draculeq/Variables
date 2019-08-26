using System;
using Deadbit.Variables.Generic;

namespace Deadbit.Variables.Image.Variable
{
    [Serializable]
    public class ImageVariable : GenericVariable<UnityEngine.UI.Image>
    {
        public ImageVariable(UnityEngine.UI.Image value)
        {
            Value = value;
        }
    }
}