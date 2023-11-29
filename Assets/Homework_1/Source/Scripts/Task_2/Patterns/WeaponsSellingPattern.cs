using UnityEngine;

namespace TraderPattern
{
    public class WeaponsSellingPattern : ITradeBehavior
    {
        public void Interact(IReputation player)
        {
            Debug.Log($"Trader stars to sell weapons to the {player}");
        }
    }
}