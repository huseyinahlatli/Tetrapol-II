using System.Collections.Generic;
using Interfaces;
using Singleton;
using UnityEngine;

namespace Managers
{
    public class StarController : Singleton<StarController>, IStar
    {
        public int MaxStar { get; set; } = 25;
        public List<GameObject> Stars { get; set; } = new List<GameObject>();
        public bool isStarsCompleted;

        public void AddStar(GameObject star)
        {
            if (Stars.Count < MaxStar)
            {
                Stars.Add(star);
                UIManager.Instance.UpdateStarSlider();
            }
        }

        private void Update()
        {
            isStarsCompleted = Stars.Count == MaxStar;
        }
    }
}
