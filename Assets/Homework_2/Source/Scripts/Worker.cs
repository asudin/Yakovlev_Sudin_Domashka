using Assets.Homework_2.Source.Scripts.StateMachine;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Homework_2.Source.Scripts
{
    [RequireComponent(typeof(Rigidbody))]
    public class Worker : MonoBehaviour 
    {
        [SerializeField] private WorkerConfig _workerConfig;

        [Header("Zones")]
        [SerializeField] private Transform _idlingZone;
        [SerializeField] private Transform _workingZone;

        private WorkerStateMachine _stateMachine;

        public WorkerConfig WorkerConfig => _workerConfig;
        public Transform IdlingZone => _idlingZone;
        public Transform WorkingZone => _workingZone;

        public event Action Working;
        public event Action Idling;

        private void Awake() => _stateMachine = new WorkerStateMachine(this);

        private void Update() => _stateMachine.Update();

        public void Idle() => Idling?.Invoke();

        public void Work() => Working?.Invoke();
    }
}
