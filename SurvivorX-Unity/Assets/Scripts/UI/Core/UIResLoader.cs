using SurvivorX.Util.ResLoaders;
using UIFramework.Runtime;
using UIFramework.Runtime.ResLoader;
using UnityEngine;

namespace SurvivorX.UI.Core
{
    public class UIResLoader : IUIResLoader
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