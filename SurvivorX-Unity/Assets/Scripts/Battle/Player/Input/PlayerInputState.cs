using UnityEngine;

namespace SurvivorX.Battle.Player.Input
{
    public class PlayerInputState
    {
        public Vector2 MoveDirection { get; private set; }

        public void SetMoveDirection(Vector2 direction)
        {
            MoveDirection = direction;
        }
    }
}