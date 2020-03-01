using Deadbit.Events;
using UnityEngine;

namespace Deadbit.Variables
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Quaternion Variable", fileName = "Quaternion Variable")]
    public class QuaternionVariableAsset : GenericVariableAsset<Quaternion, QuaternionEvent> { }
}
