using SurvivorX.Battle;
using SurvivorX.Infrastructure;
using VContainer;
using VContainer.Unity;

namespace SurvivorX
{
    public class RootLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.AddInfrastructure();

            builder.Register<BattleFlow>(Lifetime.Singleton);
            builder.RegisterEntryPoint<Launcher>();
        }
    }
}