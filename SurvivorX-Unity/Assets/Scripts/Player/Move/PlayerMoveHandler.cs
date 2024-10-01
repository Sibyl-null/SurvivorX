using SurvivorX.Global.TimeProviders;
using SurvivorX.Player.Input;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Player.Move
{
    public class PlayerMoveHandler : ITickable
    {
        private readonly PlayerInputState _inputState;
        private readonly IMover _mover;
        private readonly ITimeProvider _timeProvider;

        [Inject]
        public PlayerMoveHandler(PlayerInputState inputState, IMover mover, ITimeProvider timeProvider)
        {
            _inputState = inputState;
            _mover = mover;
            _timeProvider = timeProvider;
        }
        
        public void Tick()
        {
            Vector2 movement = _inputState.MoveDirection * _timeProvider.DeltaTime * 5;
            Vector2 oldPosition = _mover.GetPosition();
            _mover.SetPosition(oldPosition + movement);
        }
    }
}
