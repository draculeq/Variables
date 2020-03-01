using Deadbit.Events;
using UnityEngine;

namespace Deadbit.Variables
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Texture Variable", fileName = "Texture Variable")]
    public class TextureVariableAsset : GenericVariableAsset<Texture2D, TextureEvent> { }
}