using Deadbit.Events;
using UnityEngine;

namespace Deadbit.Variables
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Color Variable", fileName = "Color Variable")]
    public class ColorVariableAsset : GenericVariableAsset<Color, ColorEvent> { }
}
