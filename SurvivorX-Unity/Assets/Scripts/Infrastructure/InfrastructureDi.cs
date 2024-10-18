using SurvivorX.Infrastructure.ResLoaders;
using SurvivorX.Infrastructure.TimeProviders;
using VContainer;

namespace SurvivorX.Infrastructure
{
    public static class InfrastructureDi
    {
        public static IContainerBuilder AddInfrastructure(this IContainerBuilder builder)
        {
            builder.Register<ITimeProvider, TimeProvider>(Lifetime.Singleton);
            builder.Register<IResLoader, ResLoader>(Lifetime.Singleton);
            return builder;
        }
    }
}
