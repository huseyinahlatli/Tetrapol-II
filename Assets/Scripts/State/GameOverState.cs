using Managers;
using Statics;

namespace State
{
    public class GameOverState : BaseState
    {
        public override void EnterState()
        {
            UIPanels.GameOver();
            GameManager.Instance.PlayGameStateSound(GameManager.Instance.gameOverSound);
            GameManager.Instance.AutoRestartGame();
        }

        public override void UpdateState(StateManager state) { }
    }
}
