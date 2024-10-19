using SurvivorX.Battle.Common;
using SurvivorX.Config;
using UnityEngine;
using VContainer;

namespace SurvivorX.Battle.Player
{
    public class PlayerCharacter : MonoBehaviour, IMover, IPlayerFacade
    {
        [Inject] private readonly PlayerStatConfigSo _playerStat;
        
        public Vector2 Position => Trans.position;
        public float MoveSpeed => _playerStat.MoveSpeed;
        public Transform Trans => transform;
    }
}