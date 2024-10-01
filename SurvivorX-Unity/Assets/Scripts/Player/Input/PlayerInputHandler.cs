using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Player.Input
{
    public class PlayerInputHandler : IInitializable, ITickable
    {
        private readonly PlayerInputAction _inputActions = new();
        private readonly PlayerInputState _inputState;

        [Inject]
        public PlayerInputHandler(PlayerInputState inputState)
        {
            _inputState = inputState;
        }
        
        public void Initialize()
        {
            _inputActions.Enable();
        }
        
        public void Tick()
        {
            _inputState.SetMoveDirection(_inputActions.Player.Move.ReadValue<Vector2>());
        }
    }
}