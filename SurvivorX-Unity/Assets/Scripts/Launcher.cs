using SurvivorX.Battle;
using VContainer;
using VContainer.Unity;

namespace SurvivorX
{
    public class Launcher : IStartable
    {
        private readonly BattleFlow _battleFlow;

        [Inject]
        public Launcher(BattleFlow battleFlow)
        {
            _battleFlow = battleFlow;
        }

        public void Start()
        {
            _battleFlow.StartBattle();
        }
    }
}