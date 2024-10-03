using SurvivorX.Util.ResLoaders;
using UIFramework.Runtime;
using UnityEngine;
using IResLoader = UIFramework.Runtime.ResLoader.IResLoader;

namespace SurvivorX.UI.Core
{
    public class UIResLoader : IResLoader
    {
        public GameObject LoadAndInstantiatePrefab(string path, Transform parent)
        {
            GameObject prefab = ResLoader.Instance.Load<GameObject>(path);
            if (prefab == null)
            {
                UILogger.Warning($"[UI] Load prefab failed! {path}");
                return null;
            }
            
            return Object.Instantiate(prefab, parent);
        }

        public void UnLoad(string path)
        {
            ResLoader.Instance.Unload(path);
        }

        public UIRuntimeSettings LoadSettings()
        {
            return ResLoader.Instance
                .Load<UIRuntimeSettings>("Assets/AssetBundle/UI/Settings/UIRuntimeSettings.asset");
        }
    }
}