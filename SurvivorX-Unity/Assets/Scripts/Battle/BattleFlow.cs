using SurvivorX.Battle.Enemy;
using SurvivorX.Battle.Player;
using SurvivorX.Infrastructure.ResLoaders;
using SurvivorX.Player;
using SurvivorX.Util.Defines;
using SurvivorX.Util.FluentExtensions;
using UnityEngine;
using VContainer;

namespace SurvivorX.Battle
{
    public class BattleFlow
    {
        private readonly IResLoader _resLoader;

        [Inject]
        public BattleFlow(IResLoader resLoader)
        {
            _resLoader = resLoader;
        }

        public void StartBattle()
        {
            PlayerCharacter player = _resLoader.Load<GameObject>(AssetPathDefine.PlayerPrefabPath)
                .Instantiate()
                .SetPosition(Vector3.zero)
                .GetComponent<PlayerCharacter>();
            
            _resLoader.Load<GameObject>(AssetPathDefine.EnemyPrefabPath)
                .Instantiate()
                .SetPosition(new Vector3(5, 5, 0))
                .GetComponent<EnemyCharacter>();
        }
    }
}