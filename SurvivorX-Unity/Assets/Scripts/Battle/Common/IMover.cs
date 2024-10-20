﻿using UnityEngine;

namespace SurvivorX.Battle.Common
{
    public interface IMover
    {
        float MoveSpeed { get; }
        Transform Trans { get; }
    }

    public static class MoverExtensions
    {
        public static Vector2 GetPosition(this IMover mover)
        {
            return mover.Trans.position;
        }

        public static void SetPosition(this IMover mover, Vector2 position)
        {
            mover.Trans.position = position;
        }
    }
}