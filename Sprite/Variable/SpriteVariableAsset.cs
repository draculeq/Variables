using Deadbit.Events;
using Deadbit.Variables.Generic;
using UnityEngine;

namespace Deadbit.Variables.Sprite.Variable
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Sprite Variable", fileName = "Sprite Variable")]
    public class SpriteVariableAsset : GenericVariableAsset<UnityEngine.Sprite, SpriteEvent> { }
}
