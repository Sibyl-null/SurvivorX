using JetBrains.Annotations;
using UnityEngine;

namespace SurvivorX.Infrastructure.ResLoaders
{
    [UsedImplicitly]
    public class ResLoader : IResLoader
    {
        public T Load<T>(string path) where T : Object
        {
#if UNITY_EDITOR
            return UnityEditor.AssetDatabase.LoadAssetAtPath<T>(path);
#endif
            return null;
        }

        public void Unload(string path)
        {
        }
    }
}