using Deadbit.Events;
using UnityEngine;
using UnityEngine.UI;

namespace Deadbit.Variables
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Image Variable", fileName = "Image Variable")]
    public class ImageVariableAsset : GenericVariableAsset<Image, ImageEvent> { }
}
