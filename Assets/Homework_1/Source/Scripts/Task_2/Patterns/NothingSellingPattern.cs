using UnityEngine;

namespace TraderPattern
{
    public class NothingSellingPattern : ITradeBehavior
    {
        public void Interact(IReputation player)
        {
            Debug.Log($"NPC won't sell anything to the {player}");
        }
    }
}