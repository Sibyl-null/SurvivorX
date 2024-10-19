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
        }
    }
}