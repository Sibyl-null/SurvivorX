using SurvivorX.Battle.Enemy.Move;
using SurvivorX.Battle.Skills;
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
        [SerializeField] private TouchSkill _touchSkill;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_enemyStat);
            builder.RegisterComponent(_enemyCharacter).AsImplementedInterfaces();
            builder.RegisterEntryPoint<EnemyMoveHandler>(Lifetime.Scoped);

            SkillsInit();
        }

        private void SkillsInit()
        {
            _touchSkill.Init(_enemyStat.Atk);
        }
    }
}
