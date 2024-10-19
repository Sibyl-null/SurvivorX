using SurvivorX.Battle.Common;
using UnityEngine;

namespace SurvivorX.Battle.Skills
{
    public class TouchSkill : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            HurtBox hurtBox = other.GetComponent<HurtBox>();
            if (hurtBox == null)
                return;

            hurtBox.BeHit(1);
        }
    }
}