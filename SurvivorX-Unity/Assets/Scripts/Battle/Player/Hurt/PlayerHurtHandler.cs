using SurvivorX.Battle.Common;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Battle.Player.Hurt
{
    public class PlayerHurtHandler : IInitializable
    {
        private readonly HurtBox _hurtBox;

        [Inject]
        public PlayerHurtHandler(HurtBox hurtBox)
        {
            _hurtBox = hurtBox;
        }

        public void Initialize()
        {
            _hurtBox.RegisterBeHitAction(OnBeHit);
        }

        private void OnBeHit(int damage)
        {
            Debug.Log("Player was hit");
        }
    }
}