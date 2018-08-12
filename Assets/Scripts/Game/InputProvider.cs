using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game {
    public class InputProvider: Singleton<InputProvider> {
        public IPlayerInput GetInput() {
            return FindObjectOfType<PlayerInputUI>();
        }
    }
}
