using Cysharp.Threading.Tasks;
using UnityEngine;

namespace SurvivorX.Actors
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer _spRenderer; 
        
        private Transform _targetTrans;
        private Transform _transform;
        private int _hp;

        public void Init(Transform targetTrans)
        {
            _targetTrans = targetTrans;
            _transform = transform;
            _hp = 5;
        }

        private void Update()
        {
            if (_targetTrans == null)
                return;
            
            Vector3 direction = (_targetTrans.position - _transform.position).normalized;
            Vector3 movement = direction * Time.deltaTime * 2;
            _transform.position += movement;
        }

        public async UniTaskVoid BeHurt()
        {
            _spRenderer.color = Color.red;
            --_hp;
            
            if (_hp <= 0)
            {
                Destroy(gameObject);
                Global.Exp.Value++;
                GameStateController.Instance.MakeGameWin();
                return;
            }
            
            await UniTask.Delay(300, cancellationToken: this.GetCancellationTokenOnDestroy());
            _spRenderer.color = Color.white;
        }
    }
}