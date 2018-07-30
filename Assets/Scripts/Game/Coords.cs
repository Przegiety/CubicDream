using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game {
    struct Coords {
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
        //TODO: methods

    }
}
