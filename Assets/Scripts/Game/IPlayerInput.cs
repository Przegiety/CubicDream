using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game {
    public interface IPlayerInput {
        bool Up { get; }
        bool Down { get; }
        bool Left { get; }
        bool Right { get; }
    }
}
