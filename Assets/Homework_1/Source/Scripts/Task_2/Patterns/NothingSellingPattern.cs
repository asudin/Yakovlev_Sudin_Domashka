using UnityEngine;

namespace TraderPattern
{
    public class NothingSellingPattern : ITrader
    {
        public void Interact(IReputable player)
        {
            Debug.Log($"NPC won't sell anything to the {player}");
        }
    }
}