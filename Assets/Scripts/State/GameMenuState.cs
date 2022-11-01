using Managers;
using Statics;
using UnityEngine;

namespace State
{
    public class GameMenuState : BaseState
    {
        public override void EnterState()
        {
            UIPanels.GameMenu(true);
            Time.timeScale = 0f;
        }

        public override void UpdateState(StateManager state)
        {
            if (UIManager.Instance.isStart || Input.GetKeyDown(KeyCode.Space))
            {
                Time.timeScale = 1f;
                GameManager.Instance.GetComponent<AudioSource>().enabled = true;
                UIPanels.GameMenu(false);
                state.SwitchState(state.RunState);
            }
        }
    }
}


