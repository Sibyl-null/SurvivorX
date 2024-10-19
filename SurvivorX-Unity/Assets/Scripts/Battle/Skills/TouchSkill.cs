using SurvivorX.Battle.Common;
using UnityEngine;

namespace SurvivorX.Battle.Skills
{
    public class TouchSkill : MonoBehaviour
    {
        private int Atk { get; set; }

        public void Init(int atk)
        {
            Atk = atk;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            HurtBox hurtBox = other.GetComponent<HurtBox>();
            if (hurtBox == null)
                return;

            hurtBox.BeHit(Atk);
        }
    }
}