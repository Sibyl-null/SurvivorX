using JetBrains.Annotations;
using UnityEngine;

namespace SurvivorX.Infrastructure.TimeProviders
{
    [UsedImplicitly]
    public class TimeProvider : ITimeProvider
    {
        public float DeltaTime => Time.deltaTime;
    }
}