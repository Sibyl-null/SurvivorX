using UnityEngine;

namespace SurvivorX
{
    public class Player : MonoBehaviour
    {
        private Transform _transform;
        
        private void Awake()
        {
            _transform = transform;
        }

        private void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            
            Vector2 direction = new Vector2(horizontalInput, verticalInput).normalized;
            Vector2 movement = direction * Time.deltaTime * 5;
            _transform.position = (Vector2)_transform.position + movement;
        }
    }
}
