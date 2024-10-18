using SurvivorX.Infrastructure.TimeProviders;
using SurvivorX.Misc;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Enemy.Move
{
    public class EnemyMoveHandler : ITickable
    {
        private readonly ITimeProvider _timeProvider;
        private readonly IMover _mover;
        private readonly ITransTarget _transTarget;

        [Inject]
        public EnemyMoveHandler(ITimeProvider timeProvider, IMover mover, ITransTarget transTarget)
        {
            _timeProvider = timeProvider;
            _mover = mover;
            _transTarget = transTarget;
        }
        
        public void Tick()
        {
            if (_transTarget == null)
                return;
            
            Vector2 selfPosition = _mover.GetPosition();
            Vector2 dir = (_transTarget.Position - selfPosition).normalized;
            Vector2 movement = dir * _mover.MoveSpeed * _timeProvider.DeltaTime;
            _mover.SetPosition(selfPosition + movement);
        }
    }
}
