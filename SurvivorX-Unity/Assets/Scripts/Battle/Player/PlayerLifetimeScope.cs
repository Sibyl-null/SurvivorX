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
            builder.RegisterInstance(_playerCharacter.InputState);
            builder.RegisterComponent(_playerCharacter).AsImplementedInterfaces();
            
            builder.RegisterEntryPoint<PlayerInputHandler>();
            builder.RegisterEntryPoint<PlayerMoveHandler>();
        }
    }
}
