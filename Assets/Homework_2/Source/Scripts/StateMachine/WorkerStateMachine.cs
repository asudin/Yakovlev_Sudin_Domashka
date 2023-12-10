using Assets.Homework_2.Source.Scripts.StateMachine.State;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Homework_2.Source.Scripts.StateMachine
{
    public class WorkerStateMachine : IStateSwitcher
    {
        private List<IState> _states;
        private IState _currentState;

        public WorkerStateMachine(Worker worker)
        {
            StateMachineData data = new StateMachineData();

            _states = new List<IState>()
            {
                new RunningState(this, data, worker),
                new WorkingState(this, data, worker),
                new IdlingState(this, data, worker)
            };

            _currentState = _states.First();
            _currentState.Enter();
        }

        public void SwitchState<State>() where State : IState
        {
            IState state = _states.FirstOrDefault(state => state is State);

            _currentState.Exit();
            _currentState = state;
            _currentState.Enter();
        }

        public void Update() => _currentState.Update();
    }
}
