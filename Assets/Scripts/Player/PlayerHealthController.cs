using Abstracts;
using Managers;
using Singleton;
using State;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class PlayerHealthController : Singleton<PlayerHealthController>, IHealth
    {
        [SerializeField] private Slider slider;
        [SerializeField] private Gradient gradient;
        [SerializeField] private Image fillAmount;

        public int CurrentHealth { get; set; } = 100;
        public int MaxHealth { get; set; } = 100;

        private void Start()
        {
            SetMaxHealth(MaxHealth);
        }

        public void SetHealth(int health)
        {
            slider.value = health;
            fillAmount.color = gradient.Evaluate(slider.normalizedValue);
        }

        public void SetMaxHealth(int maxHealth)
        {
            slider.maxValue = maxHealth;
            slider.value = maxHealth;
        }

        public void DealDamage(int amount) // Available Method
        {
            if (CurrentHealth - amount < 0 || GameManager.Instance.isFinish) return;
            CurrentHealth -= amount;
            SetHealth(CurrentHealth);
        }
    }
}

