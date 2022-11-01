using UnityEngine;

namespace Interfaces
{
    public interface ITrigger
    {
        void OnTriggerEnter(Collider other);
    }
}
