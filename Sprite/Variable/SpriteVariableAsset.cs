using Deadbit.Events;
using UnityEngine;

namespace Deadbit.Variables
{
    [CreateAssetMenu(menuName = "Deadbit/Variables/Sprite Variable", fileName = "Sprite Variable")]
    public class SpriteVariableAsset : GenericVariableAsset<Sprite, SpriteEvent> { }
}
