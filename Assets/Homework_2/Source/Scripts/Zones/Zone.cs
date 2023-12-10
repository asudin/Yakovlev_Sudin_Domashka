using UnityEngine;

namespace Assets.Homework_2.Source.Scripts
{
    [RequireComponent(typeof(BoxCollider))]
    public abstract class Zone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out Worker worker))
            {
                InvokeAction(worker);
            }
        }

        protected abstract void InvokeAction(Worker worker);
    }
}