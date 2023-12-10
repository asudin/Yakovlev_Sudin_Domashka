namespace Assets.Homework_2.Source.Scripts.StateMachine.State
{
    internal class IdlingState : ActionState
    {
        public IdlingState(IStateSwitcher stateSwitcher, StateMachineData data, Worker worker) : base(stateSwitcher, data, worker)
        { }

        public override void OnTimerEnd()
        {
            base.OnTimerEnd();

            Data.NextZone = Worker.WorkingZone;
        }
    }
}
