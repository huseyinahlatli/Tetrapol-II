using System;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using Singleton;
using Player;

namespace Managers
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private GameObject player;
        public GameObject finishWay;
        [Space]
        [Header ("Game Sounds")]
        public AudioClip coinSound;
        public AudioClip damageSound;
        public AudioClip enemySpawnSound;
        public AudioClip gameOverSound;
        public AudioClip gameWinSound;
        [Space]
        [Header ("Game States")]
        public bool isFinish;
        public bool isGameOver;
        
        private const int Delay = 5;
        private const float Volume = 1f;

        #region SFX Controller
        
        public void PlayCoinSound(Vector3 soundPosition)
        {
            if (!isGameOver) { AudioSource.PlayClipAtPoint(coinSound, soundPosition, Volume); }
        }

        public void PlayDamageSound(Vector3 soundPosition)
        {
            if (!isGameOver) { AudioSource.PlayClipAtPoint(damageSound, soundPosition, Volume); }
        }

        public void PlayEnemySpawnSound(Vector3 soundPosition)
        {
            AudioSource.PlayClipAtPoint(enemySpawnSound, soundPosition, Volume);
        }
        
        public void PlayGameStateSound(AudioClip sound)
        {
            AudioSource.PlayClipAtPoint(sound, player.transform.position, Volume);
            transform.GetComponent<AudioSource>().enabled = false;
        }
        
        #endregion SFX Controller

        public void AutoRestartGame()
        {
            StartCoroutine(AutoRestart());
        }
        
        private IEnumerator AutoRestart()
        {
            yield return new WaitForSeconds(Delay);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            player.GetComponent<PlayerController>().enabled = false;
        }
    }
}
