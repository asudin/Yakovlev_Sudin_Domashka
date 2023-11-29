using UnityEngine;

namespace TraderPattern
{
    public class WeaponsSellingPattern : ITrader
    {
        public void Interact(IReputable player)
        {
            Debug.Log($"Trader stars to sell weapons to the {player}");
        }
    }
}