using Deadbit.Events;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.Bool.Variable
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Bool Variable", fileName = "Bool Variable")]
    public class BoolVariableAsset : GenericVariableAsset<bool, BoolEvent> { }
}
