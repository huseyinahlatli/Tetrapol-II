using UnityEngine;
using Singleton;
using UnityEngine.UI;

namespace Managers
{
    public class UIManager : Singleton<UIManager>
    {
        [SerializeField] private Slider starSlider;
        public GameObject winPanel;
        public GameObject losePanel;
        public bool isStart;

        private void Start()
        {
            starSlider.maxValue = StarController.Instance.MaxStar;
            starSlider.value = 0f;
        }

        public void UpdateStarSlider()
        {
            if (starSlider.value < starSlider.maxValue)
            {
                starSlider.value = StarController.Instance.Stars.Count;
            }
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        public void StartGame()
        {
            isStart = true;
        }
    }
}
