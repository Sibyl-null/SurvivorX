using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using SurvivorX.Infrastructure.TimeProviders;
using SurvivorX.Misc;
using SurvivorX.Player;
using SurvivorX.Player.Input;
using SurvivorX.Player.Move;
using UnityEngine;

namespace Tests
{
    public class PlayerTest : VContainerTestFixture
    {
        [Test(Description = "按下方向键，玩家角色移动")]
        public void PressDirectionKey_Then_PlayerMove()
        {
            GameObject go = new GameObject();
            PlayerCharacter character = go.AddComponent<PlayerCharacter>();
            character.transform.position = Vector3.zero;
            character.SetMoveSpeed(10f);
            RegisterComponent(character).As<IMover>();
            
            ITimeProvider timeProvider = Substitute.For<ITimeProvider>();
            timeProvider.DeltaTime.Returns(1);
            RegisterInstance(timeProvider).As<ITimeProvider>();
            
            PlayerInputState inputState = new PlayerInputState();
            inputState.SetMoveDirection(new Vector2(1, 1));
            RegisterInstance(inputState).As<PlayerInputState>();
            
            PlayerMoveHandler moveHandler = RegisterAndResolve<PlayerMoveHandler>();
            moveHandler.Tick();
            character.transform.position.Should().Be(new Vector3(10, 10, 0));
        }
    }
}
