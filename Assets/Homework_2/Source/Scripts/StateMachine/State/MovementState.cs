using System;
using UnityEngine;

namespace Assets.Homework_2.Source.Scripts.StateMachine.State
{
    internal class MovementState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly StateMachineData Data;

        private static readonly float _distanceFromZone = 0.01f;
        private readonly Worker _worker;
        private Action _switchState;
        private Transform _targetZone;

        public MovementState(IStateSwitcher stateSwitcher, StateMachineData data, Worker worker)
        {
            StateSwitcher = stateSwitcher;
            Data = data;
            _worker = worker;
        }

        public virtual void Enter()
        {
            Debug.Log(GetType());
            _targetZone = Data.NextZone ?? _worker.IdlingZone;
            _worker.Idling += OnIdleZoneReach;
            _worker.Working += OnWorkZoneReach;
        }

        public virtual void Exit()
        {
            _targetZone = null;
            _worker.Idling -= OnIdleZoneReach;
            _worker.Working -= OnWorkZoneReach;
        }

        public virtual void Update()
        {
            _worker.transform.position = Vector3.MoveTowards(
                _worker.transform.position,
                _targetZone.position,
                _worker.WorkerConfig.RunningStateConfig.Speed * Time.deltaTime);

            if (Vector3.Distance(_worker.transform.position, _targetZone.position) < _distanceFromZone)
            {
                _switchState();
            }
        }

        private void OnWorkZoneReach() => _switchState = () => { StateSwitcher.SwitchState<WorkingState>(); };

        private void OnIdleZoneReach() => _switchState = () => { StateSwitcher.SwitchState<IdlingState>(); };
    }
}
