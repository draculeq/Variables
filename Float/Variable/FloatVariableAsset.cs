using Deadbit.Events;
using UnityEngine;

namespace Deadbit.Variables
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Float Variable", fileName = "Float Variable")]
    public class FloatVariableAsset : GenericVariableAsset<float, FloatEvent> { }
}