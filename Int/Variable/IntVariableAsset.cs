using Deadbit.Events;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.Int.Variable
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Int Variable", fileName = "Int Variable")]
    public class IntVariableAsset : GenericVariableAsset<int, IntEvent> { }
}
