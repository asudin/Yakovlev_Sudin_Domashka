using UnityEngine;

namespace Assets.Homework_2.Source.Scripts.StateMachine.State
{
    internal class ActionState : IState
    {
        protected readonly IStateSwitcher StateSwitcher;
        protected readonly StateMachineData Data;
        protected readonly Worker Worker;

        private float _actionTime;
        private float _timer;

        public ActionState(IStateSwitcher stateSwitcher, StateMachineData data, Worker worker)
        {
            StateSwitcher = stateSwitcher;
            Data = data;
            Worker = worker;
        }

        public virtual void Enter()
        {
            Debug.Log(GetType());
            Data.IsBusy = true;
            _actionTime = Worker.WorkerConfig.ActionStatesConfig.ActionTime;
        }

        public virtual void Exit()
        {
            _timer = 0;
            Data.IsBusy = false;
        }

        public virtual void Update()
        {
            _timer += Time.deltaTime;

            if (!(_timer >= _actionTime))
                return;

            StateSwitcher.SwitchState<RunningState>();
            OnTimerEnd();
        }

        public virtual void OnTimerEnd() { }
    }
}