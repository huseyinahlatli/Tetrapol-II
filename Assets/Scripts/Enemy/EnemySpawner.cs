using Abstracts;
using UnityEngine;

namespace Enemy
{
    public class EnemySpawner : MonoBehaviour, ITrigger
    {
        [SerializeField] private GameObject enemyPrefab;
        private static readonly Vector3 Position = new Vector3(0f, 1f, -8f);
        private bool _isSpawn;
    
        public void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(StringCache.Enemy) && !_isSpawn)
            {
                var enemySpawn = Instantiate(enemyPrefab, Position, Quaternion.identity);
                _isSpawn = true;
                gameObject.SetActive(false);
            }
        }
    }
}
