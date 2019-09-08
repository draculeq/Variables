using Deadbit.Events;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.Texture.Variable
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Texture Variable", fileName = "Texture Variable")]
    public class TextureVariableAsset : GenericVariableAsset<Texture2D, TextureEvent> { }
}