using System;
using UnityEngine.UI;

namespace Deadbit.Variables
{
    [Serializable]
    public class ImageVariable : GenericVariable<Image>
    {
        public ImageVariable(Image value)
        {
            Value = value;
        }
    }
}