using SurvivorX.Global.TimeProviders;
using VContainer;
using VContainer.Unity;

namespace SurvivorX.Global
{
    public class GlobalLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<ITimeProvider, TimeProvider>(Lifetime.Singleton);
        }
    }
}