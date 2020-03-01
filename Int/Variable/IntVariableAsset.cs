using Deadbit.Events;
using UnityEngine;

namespace Deadbit.Variables
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Int Variable", fileName = "Int Variable")]
    public class IntVariableAsset : GenericVariableAsset<int, IntEvent> { }
}
