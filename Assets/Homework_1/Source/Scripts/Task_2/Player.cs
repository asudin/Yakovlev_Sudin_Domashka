using System;
using UnityEngine;

namespace TraderPattern
{
    public class Player : MonoBehaviour, IReputable
    {
        private const int RatingChangeValue = 1;

        [SerializeField, Range(0, 10)] private int _rating = 5;

        public int Rating => _rating;
        public event Action<int> RatingChanged;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                IncreaseRating(RatingChangeValue);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                DecreaseRating(RatingChangeValue);
            }
        }

        private void IncreaseRating(int value)
        {
            if (value < 0)
                return;

            _rating += value;
            RatingChanged?.Invoke(_rating);
        }

        private void DecreaseRating(int value)
        {
            if (value < 0)
                return;

            _rating -= value;
            RatingChanged?.Invoke(_rating);
        }
    }
}