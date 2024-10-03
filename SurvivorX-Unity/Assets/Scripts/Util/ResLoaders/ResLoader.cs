using UnityEngine;

namespace SurvivorX.Util.ResLoaders
{
    public class ResLoader : IResLoader
    {
        public static ResLoader Instance { get; } = new();
        
        public T Load<T>(string path) where T : Object
        {
#if UNITY_EDITOR
            return UnityEditor.AssetDatabase.LoadAssetAtPath<T>(path);
#endif
        }

        public void Unload(string path)
        {
        }
    }
}