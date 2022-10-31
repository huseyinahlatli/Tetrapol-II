using UnityEngine;

namespace Abstracts
{
    public interface ITrigger
    {
        void OnTriggerEnter(Collider other);
    }
}
