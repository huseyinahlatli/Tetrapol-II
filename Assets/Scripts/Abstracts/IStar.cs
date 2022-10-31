using System.Collections.Generic;
using UnityEngine;

namespace Abstracts
{
    public interface IStar
    {
        public int MaxStar { get; set; }

        public List<GameObject> Stars { get; set; }
    }
}