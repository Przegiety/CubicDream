using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Game {
    [Serializable]
    public struct Coords {
        public int x, y, z;

        public Coords(int x, int y, int z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override bool Equals(object obj) {
            if (!(obj is Coords)) {
                return false;
            }

            var coords = (Coords)obj;
            return x == coords.x &&
                   y == coords.y &&
                   z == coords.z;
        }

        public override int GetHashCode() {
            var hashCode = 373119288;
            hashCode = hashCode * -1521134295 + x.GetHashCode();
            hashCode = hashCode * -1521134295 + y.GetHashCode();
            hashCode = hashCode * -1521134295 + z.GetHashCode();
            return hashCode;
        }

        public static Coords operator +(Coords c1, Coords c2) {
            return new Coords(c1.x + c2.x, c1.y + c2.y, c1.z + c2.z);
        }
        public static explicit operator Vector3(Coords c) {
            return new Vector3(c.x, c.y, c.z);
        }
    }
}
