using SurvivorX.Battle.Player;
using SurvivorX.Infrastructure.ResLoaders;
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

            IPlayerFacade playerFacade = _resLoader.Load<GameObject>(AssetPathDefine.PlayerPrefabPath)
                .Instantiate()
                .SetPosition(Vector3.zero)
                .GetComponent<IPlayerFacade>();
            
            builder.RegisterInstance(playerFacade).As<IPlayerFacade>();

            _resLoader.Load<GameObject>(AssetPathDefine.EnemyPrefabPath)
                .Instantiate()
                .SetPosition(new Vector3(5, 5, 0));
        }
    }
}