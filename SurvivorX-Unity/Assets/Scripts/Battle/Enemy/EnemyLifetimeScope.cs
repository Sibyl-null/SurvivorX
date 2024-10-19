using SurvivorX.Battle.Enemy.Move;
using SurvivorX.Config;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Battle.Enemy
{
    public class EnemyLifetimeScope : LifetimeScope
    {
        [SerializeField] private EnemyStatConfigSo _enemyStat;
        [SerializeField] private EnemyCharacter _enemyCharacter;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_enemyStat);
            builder.RegisterComponent(_enemyCharacter).AsImplementedInterfaces();
            builder.RegisterEntryPoint<EnemyMoveHandler>(Lifetime.Scoped);
        }
    }
}
