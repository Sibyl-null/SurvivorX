using UnityEngine;

namespace SurvivorX.Actors
{
    public class Enemy : MonoBehaviour
    {
        private Transform _targetTrans;
        private Transform _transform;

        private void Awake()
        {
            _targetTrans = GameObject.FindWithTag("Player").transform;
            _transform = transform;
        }

        private void Update()
        {
            if (_targetTrans == null)
                return;
            
            Vector2 direction = (_targetTrans.position - _transform.position).normalized;
            Vector2 movement = direction * Time.deltaTime * 2;
            _transform.position = (Vector2)_transform.position + movement;
        }
    }
}