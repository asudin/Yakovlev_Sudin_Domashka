using UnityEngine;

namespace TraderPattern
{
    public class PotionsSellingPattern : ITradeBehavior
    {
        public void Interact(IReputation player)
        {
            Debug.Log($"Trader sells potions to the {player}");
        }
    }
}