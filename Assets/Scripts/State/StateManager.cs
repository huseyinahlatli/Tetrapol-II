using UnityEngine;

namespace State
{
    public class StateManager : MonoBehaviour
    {
        public BaseState CurrentState;
        public GameMenuState MenuState = new GameMenuState();
        public GameRunState RunState = new GameRunState();
        public GameWinState WinState = new GameWinState();
        public GameOverState OverState = new GameOverState();
        
        private void Start()
        {
            CurrentState = MenuState;
            CurrentState.EnterState();
        }

        private void Update()
        {
            CurrentState.UpdateState(this);
        }

        public void SwitchState(BaseState state)
        {
            CurrentState = state;
            CurrentState.EnterState();
        }
    }
}
