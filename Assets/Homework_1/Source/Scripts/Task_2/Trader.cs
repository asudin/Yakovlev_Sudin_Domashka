using UnityEngine;

namespace TraderPattern
{
    public class Trader : MonoBehaviour
    {
        private ITradeBehavior _behavior;

        public void Initialize(ITradeBehavior behavior)
        {
            _behavior = behavior;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out IReputation reputable))
            {
                Debug.Log($"{reputable} activated trader menu!");
                _behavior?.Interact(reputable);
            }
        }
    }
}