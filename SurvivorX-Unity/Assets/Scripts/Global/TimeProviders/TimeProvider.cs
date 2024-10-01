using JetBrains.Annotations;
using UnityEngine;

namespace SurvivorX.Global.TimeProviders
{
    [UsedImplicitly]
    public class TimeProvider : ITimeProvider
    {
        public float DeltaTime => Time.deltaTime;
    }
}