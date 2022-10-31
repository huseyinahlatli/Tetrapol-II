using Managers;
using Player;

namespace State
{
    public class GameRunState : BaseState
    {
        public override void EnterState() { }

        public override void UpdateState(StateManager state)
        {
            if (StarController.Instance.isStarsCompleted)
            {
                GameManager.Instance.finishWay.SetActive(true);
            }
            
            if (PlayerHealthController.Instance.CurrentHealth <= 0 || PlayerController.Instance.isFall)
            {
                state.SwitchState(state.OverState);
            }

            if (StarController.Instance.isStarsCompleted && GameManager.Instance.isFinish)
            {  
                state.SwitchState(state.WinState);
            }
        }
    }
}