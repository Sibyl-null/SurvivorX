using QFramework;
using UnityEngine;

namespace SurvivorX.Actors
{
    public class Player : MonoBehaviour
    {
        private Transform _transform;
        [SerializeField] private Collider2D _hurtBox;
        
        private void Awake()
        {
            _transform = transform;

            _hurtBox.OnTriggerEnter2DEvent(OnHurtBoxEnter)
                .UnRegisterWhenGameObjectDestroyed(gameObject);
        }

        private void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            
            Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;
            Vector2 movement = direction * Time.deltaTime * 5;
            _transform.position = (Vector2)_transform.position + movement;
        }
        
        private void OnHurtBoxEnter(Collider2D box)
        {
            Destroy(gameObject);
            GameStateController.Instance.MakeGameFail();
        }
    }
}
