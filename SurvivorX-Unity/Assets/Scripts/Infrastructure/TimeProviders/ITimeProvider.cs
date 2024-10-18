namespace SurvivorX.Infrastructure.TimeProviders
{
    public interface ITimeProvider
    {
        float DeltaTime { get; }
    }
}