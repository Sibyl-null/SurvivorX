using SurvivorX.Battle.Common;
using UnityEngine;

namespace SurvivorX.Battle.Enemy
{
    public class EnemyCharacter : MonoBehaviour, IMover
    {
        private Transform _trans;
        [SerializeField] private float _moveSpeed;
        
        public float MoveSpeed => _moveSpeed;
        public Transform Trans
        {
            get
            {
                if (_trans == null)
                    _trans = transform;
                
                return _trans;
            }
        }
    }
}
