using UnityEngine;

namespace TraderPattern
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Npc _trader;

        private PatternSwitcher _switcher;

        private void Awake()
        {
            _switcher = new PatternSwitcher(_trader, _player);
        }
    }
}