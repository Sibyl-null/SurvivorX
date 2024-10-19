using SurvivorX.Battle.Player.Input;
using SurvivorX.Battle.Player.Move;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Battle.Player
{
    public class PlayerLifetimeScope : LifetimeScope
    {
        [SerializeField] private PlayerCharacter _playerCharacter;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(_playerCharacter).AsImplementedInterfaces();

            builder.Register<PlayerInputState>(Lifetime.Scoped);
            builder.RegisterEntryPoint<PlayerInputHandler>();
            builder.RegisterEntryPoint<PlayerMoveHandler>();
        }
    }
}
