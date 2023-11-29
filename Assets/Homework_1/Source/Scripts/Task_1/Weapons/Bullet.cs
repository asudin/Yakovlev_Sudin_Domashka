using UnityEngine;

namespace GunPatterns
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField][Range(2, 10)] private float _speed = 5.0f;

        private void Update()
        {
            Move();
        }

        public void Move()
        {
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        }
    }
}