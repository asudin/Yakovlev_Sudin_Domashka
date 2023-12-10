namespace Assets.Homework_2.Source.Scripts.StateMachine
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Update();
    }
}