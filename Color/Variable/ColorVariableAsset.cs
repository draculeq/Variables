using Deadbit.Events;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.Color.Variable
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Color Variable", fileName = "Color Variable")]
    public class ColorVariableAsset : GenericVariableAsset<UnityEngine.Color, ColorEvent> { }
}
