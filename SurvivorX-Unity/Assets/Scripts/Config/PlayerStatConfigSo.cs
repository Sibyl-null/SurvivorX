using UnityEngine;

namespace SurvivorX.Config
{
    [CreateAssetMenu(menuName = "Stat/PlayerStatConfig", fileName = "PlayerStatConfig")]
    public class PlayerStatConfigSo : ScriptableObject
    {
        [field: SerializeField] public int MaxHp { get; private set; } = 10;
        [field: SerializeField] public int MoveSpeed { get; private set; } = 5;
        [field: SerializeField] public int Atk { get; private set; } = 1;
    }
}