using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Entity {
    public class PlayerEntity : WorldEntity {
        private IPlayerInput _playerInput;
        private void Awake() {
            _playerInput = InputProvider.Instance.GetInput();   //Should InputProvider be a singleton or maybe just a static class
        }
        
    }
}
