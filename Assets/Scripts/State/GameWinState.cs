using Abstracts;
using Managers;

namespace State
{
    public class GameWinState : BaseState
    {
        public override void EnterState()
        {
            UIPanels.GameWin();
            GameManager.Instance.PlayGameStateSound(GameManager.Instance.gameWinSound);
            GameManager.Instance.AutoRestartGame();
        }

        public override void UpdateState(StateManager state) { }
    }
}
