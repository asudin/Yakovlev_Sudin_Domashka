namespace Assets.Homework_2.Source.Scripts.StateMachine.State
{
    internal class RunningState : MovementState
    {
        private readonly RunningStateConfig _config;

        public RunningState(IStateSwitcher stateSwitcher, StateMachineData data, Worker worker) : base(stateSwitcher, data, worker)
            => _config = worker.WorkerConfig.RunningStateConfig;

        public override void Enter()
        {
            base.Enter();

            Data.Speed = _config.Speed;
        }
    }
}
