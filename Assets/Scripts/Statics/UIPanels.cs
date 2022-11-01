using Interfaces;
using Managers;
using UnityEngine;

namespace Statics
{
    public static class UIPanels
    {
        public static void GameMenu(bool visible)
        {
            var gameMenu = GameObject.Find(StringCache.GameMenu);
            gameMenu.SetActive(visible);
        }
        
        public static void GameWin()
        {
            UIManager.Instance.winPanel.SetActive(true);
        }
        
        public static void GameOver()
        {
            UIManager.Instance.losePanel.SetActive(true);
        }
    }
}