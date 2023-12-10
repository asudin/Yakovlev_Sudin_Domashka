namespace Assets.Homework_2.Source.Scripts.StateMachine
{
    internal interface IStateSwitcher
    {
        void SwitchState<State>() where State : IState;
    }
}
