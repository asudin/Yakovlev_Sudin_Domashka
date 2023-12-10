using System;
using UnityEngine;

namespace Assets.Homework_2.Source.Scripts.StateMachine
{
    internal class StateMachineData
    {
        public Transform NextZone;

        private float _speed;
        private bool _isBusy;

        public bool IsBusy
        { 
            get => _isBusy;
            set => _isBusy = value;
        }

        public float Speed
        {
            get => _speed;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Speed));
                }

                _speed = value;
            }
        }
    }
}
