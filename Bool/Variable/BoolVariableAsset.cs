using Deadbit.Events;
using UnityEngine;

namespace Deadbit.Variables
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Bool Variable", fileName = "Bool Variable")]
    public class BoolVariableAsset : GenericVariableAsset<bool, BoolEvent> { }
}
