using SurvivorX.Battle.Common;
using SurvivorX.Config;
using UnityEngine;
using VContainer;

namespace SurvivorX.Battle.Enemy
{
    public class EnemyCharacter : MonoBehaviour, IMover
    {
        [Inject] private readonly EnemyStatConfigSo _enemyStat;
        
        public float MoveSpeed => _enemyStat.MoveSpeed;
        public Transform Trans => transform;
    }
}
