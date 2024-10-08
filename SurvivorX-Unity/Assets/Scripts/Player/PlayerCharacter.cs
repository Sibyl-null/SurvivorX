﻿using SurvivorX.Misc;
using SurvivorX.Player.Input;
using UnityEngine;

namespace SurvivorX.Player
{
    public class PlayerCharacter : MonoBehaviour, IMover, ITransTarget
    {
        private Transform _trans;
        [SerializeField] private float _moveSpeed;
        
        public PlayerInputState InputState { get; } = new();
        
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
        
        public Vector2 Position => Trans.position;
        
        public void SetMoveSpeed(float speed)
        {
            _moveSpeed = speed;
        }
    }
}