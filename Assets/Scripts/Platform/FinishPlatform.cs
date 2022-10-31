using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Platform
{
    public class FinishPlatform : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(FinishWay());
        }
    
        private IEnumerator FinishWay()
        {
            const float delay = 1f;
            for (var i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).DOMoveY(0f, delay);
                yield return new WaitForSeconds(delay);
            }
        }
    }
}
