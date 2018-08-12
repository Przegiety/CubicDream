using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game {
    public class PlayerInputUI : IPlayerInput {
        public bool Up => _up;
        public bool Down => _down;
        public bool Left => _left;
        public bool Right => _right;

        private bool _up = false;
        private bool _down = false;
        private bool _left = false;
        private bool _right = false;

        public void SetUp(bool value) {
            _up = value;
        }
        public void SetDown(bool value) {
            _down = value;
        }
        public void SetLeft(bool value) {
            _left = value;
        }
        public void SetRight(bool value) {
            _right = value;
        }
    }
}
