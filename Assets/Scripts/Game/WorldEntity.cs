using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Game {
    public class WorldEntity : MonoBehaviour {

        public Coords Position { get; protected set; }

        public void SnapPosition() {
            transform.position = (Vector3)Position;
        }
    }
}
