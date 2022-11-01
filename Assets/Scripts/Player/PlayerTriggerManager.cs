using Interfaces;
using Managers;
using Statics;
using UnityEngine;

namespace Player
{
    public class PlayerTriggerManager : MonoBehaviour, ITrigger
    {
        private const int Damage = 20;
        
        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(StringCache.Star))
            {
                StarController.Instance.AddStar(other.gameObject);
                GameManager.Instance.PlayCoinSound(transform.position);
                other.gameObject.SetActive(false);
            }

            if (other.gameObject.CompareTag(StringCache.Enemy))
            {
                GameManager.Instance.PlayDamageSound(transform.position);
                PlayerHealthController.Instance.DealDamage(Damage);
            }

            if (other.gameObject.CompareTag(StringCache.Finish))
            {
                GameManager.Instance.isFinish = true;
            }
        }
    }
}
