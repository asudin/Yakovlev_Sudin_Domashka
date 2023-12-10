namespace Assets.Homework_2.Source.Scripts.Zones
{
    internal class WorkingZone : Zone
    {
        protected override void InvokeAction(Worker worker)
        {
            worker.Work();
        }
    }
}
