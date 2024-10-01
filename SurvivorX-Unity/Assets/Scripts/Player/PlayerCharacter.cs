using SurvivorX.Player.Input;
using SurvivorX.Player.Move;
using UnityEngine;

namespace SurvivorX.Player
{
    public class PlayerCharacter : MonoBehaviour, IMover
    {
        private Transform _trans;
        
        public PlayerInputState InputState { get; } = new();
        public Transform Trans => _trans;

        private void Awake()
        {
            _trans = transform;
        }
    }
}