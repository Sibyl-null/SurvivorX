using SurvivorX.Battle.Common;
using SurvivorX.Battle.Player.Hurt;
using SurvivorX.Battle.Player.Input;
using SurvivorX.Battle.Player.Move;
using SurvivorX.Config;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Battle.Player
{
    public class PlayerLifetimeScope : LifetimeScope
    {
        [SerializeField] private PlayerStatConfigSo _playerStat;
        [SerializeField] private PlayerCharacter _playerCharacter;
        [SerializeField] private HurtBox _hurtBox;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_playerStat);
            builder.RegisterComponent(_playerCharacter).AsImplementedInterfaces();

            builder.Register<PlayerInputState>(Lifetime.Scoped);
            builder.RegisterComponent(_hurtBox);
            
            builder.RegisterEntryPoint<PlayerInputHandler>(Lifetime.Scoped);
            builder.RegisterEntryPoint<PlayerMoveHandler>(Lifetime.Scoped);
            builder.RegisterEntryPoint<PlayerHurtHandler>(Lifetime.Scoped);
        }
    }
}
