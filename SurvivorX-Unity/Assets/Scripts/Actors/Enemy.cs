using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SurvivorX.Actors
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spRenderer; 
        
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

        public async UniTaskVoid BeHurt()
        {
            _spRenderer.color = Color.red;
            await UniTask.Delay(300, cancellationToken: this.GetCancellationTokenOnDestroy());
            _spRenderer.color = Color.white;
        }
    }
}