using SurvivorX.Player.Input;
using SurvivorX.Player.Move;
using UnityEngine;

namespace SurvivorX.Player
{
    public class PlayerCharacter : MonoBehaviour, IMover
    {
        private Transform _trans;
        [SerializeField] private float _moveSpeed;
        
        public PlayerInputState InputState { get; } = new();

        public float MoveSpeed => _moveSpeed;
        public Transform Trans => _trans;

        private void Awake()
        {
            _trans = transform;
        }
    }
}