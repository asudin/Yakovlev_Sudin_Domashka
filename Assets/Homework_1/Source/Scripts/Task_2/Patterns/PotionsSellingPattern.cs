using UnityEngine;

namespace TraderPattern
{
    public class PotionsSellingPattern : ITrader
    {
        public void Interact(IReputable player)
        {
            Debug.Log($"Trader sells potions to the {player}");
        }
    }
}