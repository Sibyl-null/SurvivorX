using SurvivorX.Battle.Enemy;
using SurvivorX.Battle.Player;
using SurvivorX.Infrastructure.ResLoaders;
using SurvivorX.Misc;
using SurvivorX.Util.Defines;
using SurvivorX.Util.FluentExtensions;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Battle
{
    public class BattleLifetimeScope : LifetimeScope
    {
        private IResLoader _resLoader;

        protected override void Configure(IContainerBuilder builder)
        {
            _resLoader = Parent.Container.Resolve<IResLoader>();

            PlayerCharacter player = _resLoader.Load<GameObject>(AssetPathDefine.PlayerPrefabPath)
                .Instantiate()
                .SetPosition(Vector3.zero)
                .GetComponent<PlayerCharacter>();
            
            builder.RegisterInstance(player).As<ITransTarget>();
            
            _resLoader.Load<GameObject>(AssetPathDefine.EnemyPrefabPath)
                .Instantiate()
                .SetPosition(new Vector3(5, 5, 0))
                .GetComponent<EnemyCharacter>();
        }
    }
}