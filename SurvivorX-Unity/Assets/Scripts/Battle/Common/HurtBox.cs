using System;
using UnityEngine;

namespace SurvivorX.Battle.Common
{
    public class HurtBox : MonoBehaviour
    {
        private Action<int> _beHitAction;

        public void RegisterBeHitAction(Action<int> action)
        {
            _beHitAction = action;
        }
        
        public void BeHit(int damage)
        {
            _beHitAction?.Invoke(damage);
        }
    }
}