using System;
using UnityEngine;

namespace TraderPattern
{
    public class Player : MonoBehaviour, IReputation
    {
        private const int StartingReputationValue = 5;

        [SerializeField, Range(0, 10)] private int _rating = 5;
        private Reputation _reputation;

        public int Rating => _rating;
        public event Action<int> RatingChanged;

        private void Awake()
        {
            _reputation = new Reputation(StartingReputationValue);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _reputation.IncreaseRating();
                RatingChanged?.Invoke(_reputation.TotalReputation);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                _reputation.DecreaseRating();
                RatingChanged?.Invoke(_reputation.TotalReputation);
            }
        }
    }
}