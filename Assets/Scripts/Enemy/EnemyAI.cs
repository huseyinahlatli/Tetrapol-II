using Abstracts;
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public class EnemyAI : MonoBehaviour
    {
        private GameObject _player;
        private NavMeshAgent _agent;

        private void Start()
        {
            _player = GameObject.FindGameObjectWithTag(StringCache.Player);
            _agent = GetComponent<NavMeshAgent>();
        }

        private void Update()
        {
            _agent.destination = _player.transform.position;
        }
    }
}
