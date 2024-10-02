using SurvivorX.Misc;
using UnityEngine;

namespace SurvivorX.Enemy
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
