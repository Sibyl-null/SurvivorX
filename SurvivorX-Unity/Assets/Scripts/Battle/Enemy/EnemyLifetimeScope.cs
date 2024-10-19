using SurvivorX.Battle.Enemy.Move;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Battle.Enemy
{
    public class EnemyLifetimeScope : LifetimeScope
    {
        [SerializeField] private EnemyCharacter _enemyCharacter;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_enemyCharacter).AsImplementedInterfaces();
            builder.RegisterEntryPoint<EnemyMoveHandler>(Lifetime.Scoped);
        }
    }
}
