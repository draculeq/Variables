using Deadbit.Events;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.Float.Variable
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Float Variable", fileName = "Float Variable")]
    public class FloatVariableAsset : GenericVariableAsset<float, FloatEvent> { }
}