using Deadbit.Events;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.Quaternion.Variable
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Quaternion Variable", fileName = "Quaternion Variable")]
    public class QuaternionVariableAsset : GenericVariableAsset<UnityEngine.Quaternion, QuaternionEvent> { }
}
