namespace Assets.Homework_2.Source.Scripts.StateMachine.State
{
    internal class WorkingState : ActionState
    {
        public WorkingState(IStateSwitcher stateSwitcher, StateMachineData data, Worker worker) : base(stateSwitcher, data, worker)
        { }

        public override void OnTimerEnd()
        {
            base.OnTimerEnd();

            Data.NextZone = Worker.IdlingZone;
        }
    }
}
