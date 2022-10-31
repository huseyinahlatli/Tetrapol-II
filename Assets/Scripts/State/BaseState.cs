namespace State
{
    public abstract class BaseState
    {
        public abstract void EnterState();
        public abstract void UpdateState(StateManager state);
    }
}
