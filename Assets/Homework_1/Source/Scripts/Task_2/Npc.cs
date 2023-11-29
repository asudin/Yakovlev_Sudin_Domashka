using UnityEngine;

namespace TraderPattern
{
    public class Npc : MonoBehaviour
    {
        private ITrader _behavior;

        public void Initialize(ITrader behavior)
        {
            _behavior = behavior;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                Debug.Log($"{player} activated trader menu!");
                _behavior?.Interact(player);
            }
        }

        private void ShowTradeOptions(Player player)
        {
            Debug.Log($"Opntion 1: {player} can lower his reputation by hitting the trader on pressing the 'S' key\n" +
                $"Option 2: {player} can increase his reputation by trading with the trader on pressing the 'W' key");
        }
    }
}