using SurvivorX.Enemy.Move;
using SurvivorX.Misc;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Enemy
{
    public class EnemyLifetimeScope : LifetimeScope
    {
        [SerializeField] private EnemyCharacter _enemyCharacter;
        
        protected override void Configure(IContainerBuilder builder)
        {
            ITransTarget transTarget = GetTransTarget();
            if (transTarget != null)
                builder.RegisterInstance(transTarget).As<ITransTarget>();

            builder.RegisterComponent(_enemyCharacter).AsImplementedInterfaces();
            builder.RegisterEntryPoint<EnemyMoveHandler>();
        }

        private ITransTarget GetTransTarget()
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player == null)
                return null;
            
            return player.GetComponent<ITransTarget>();
        }
    }
}
