using System.Collections.Generic;
using UnityEngine;

namespace Interfaces
{
    public interface IStar
    {
        public int MaxStar { get; set; }

        public List<GameObject> Stars { get; set; }
    }
}