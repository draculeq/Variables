using Deadbit.Events;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.Image.Variable
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Image Variable", fileName = "Image Variable")]
    public class ImageVariableAsset : GenericVariableAsset<UnityEngine.UI.Image, ImageEvent> { }
}
