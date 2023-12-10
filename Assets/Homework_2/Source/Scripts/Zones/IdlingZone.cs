namespace Assets.Homework_2.Source.Scripts.Zones
{
    internal class IdlingZone : Zone
    {
        protected override void InvokeAction(Worker worker)
        {
            worker.Idle();
        }
    }
}
