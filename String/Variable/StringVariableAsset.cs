using Deadbit.Events;
using UnityEngine;

namespace Deadbit.Variables
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/String Variable", fileName = "String Variable")]
    public class StringVariableAsset : GenericVariableAsset<string, StringEvent> { }
}