using SurvivorX.Battle.Common;
using SurvivorX.Battle.Player;
using SurvivorX.Infrastructure.TimeProviders;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Battle.Enemy.Move
{
    public class EnemyMoveHandler : ITickable
    {
        private readonly ITimeProvider _timeProvider;
        private readonly IMover _mover;
        private readonly IPlayerFacade _playerFacade;

        [Inject]
        public EnemyMoveHandler(ITimeProvider timeProvider, IMover mover, IPlayerFacade playerFacade)
        {
            _timeProvider = timeProvider;
            _mover = mover;
            _playerFacade = playerFacade;
        }
        
        public void Tick()
        {
            if (_playerFacade == null)
                return;
            
            Vector2 selfPosition = _mover.GetPosition();
            Vector2 dir = (_playerFacade.Position - selfPosition).normalized;
            Vector2 movement = dir * _mover.MoveSpeed * _timeProvider.DeltaTime;
            _mover.SetPosition(selfPosition + movement);
        }
    }
}
