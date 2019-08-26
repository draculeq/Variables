using Deadbit.Events;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.String.Variable
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/String Variable", fileName = "String Variable")]
    public class StringVariableAsset : GenericVariableAsset<string, StringEvent> { }
}