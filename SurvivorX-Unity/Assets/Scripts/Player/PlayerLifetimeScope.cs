using SurvivorX.Player.Input;
using SurvivorX.Player.Move;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Player
{
    public class PlayerLifetimeScope : LifetimeScope
    {
        [SerializeField] private PlayerCharacter _playerCharacter;
        
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_playerCharacter.InputState);
            builder.RegisterComponent(_playerCharacter).AsImplementedInterfaces();
            
            builder.RegisterEntryPoint<PlayerInputHandler>();
            builder.RegisterEntryPoint<PlayerMoveHandler>();
        }
    }
}
