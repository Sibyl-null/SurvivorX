using SurvivorX.Actors;
using UnityEngine;

namespace SurvivorX.Abilities
{
    public class SimpleAbility : MonoBehaviour
    {
        private Transform _transform;
        private float _timeDown;

        private void Awake()
        {
            _timeDown = 1.5f;
            _transform = transform;
        }

        private void Update()
        {
            _timeDown -= Time.deltaTime;
            if (_timeDown <= 0)
            {
                _timeDown = 1.5f;
                HurtAllEnemies();
            }
        }

        private void HurtAllEnemies()
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
            {
                Enemy cp = enemy.GetComponent<Enemy>();
                if (cp == null)
                    continue;
                
                float distance = Vector3.Distance(_transform.position, enemy.transform.position);
                if (distance > 5f)
                    continue;
                
                cp.BeHurt().Forget();
            }
        }
    }
}