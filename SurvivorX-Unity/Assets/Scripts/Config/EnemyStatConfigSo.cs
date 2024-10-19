using UnityEngine;

namespace SurvivorX.Config
{
    [CreateAssetMenu(menuName = "Stat/EnemyStatConfig", fileName = "EnemyStatConfig")]
    public class EnemyStatConfigSo : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public int MaxHp { get; private set; } = 3;
        [field: SerializeField] public int MoveSpeed { get; private set; } = 3;
        [field: SerializeField] public int Atk { get; private set; } = 1;
    }
}