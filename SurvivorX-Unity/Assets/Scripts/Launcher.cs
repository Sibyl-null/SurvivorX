using SurvivorX.UI.Core;
using SurvivorX.Util.Defines;
using SurvivorX.Util.ResLoaders;
using UnityEngine;
using IResLoader = SurvivorX.Util.ResLoaders.IResLoader;

namespace SurvivorX
{
    public class Launcher : MonoBehaviour
    {
        private readonly IResLoader _resLoader = ResLoader.Instance;
        [SerializeField] private Canvas _uiRootCanvas;
        
        private void Start()
        {
            InitUIManager();
            GameStart();
        }

        private void OnDestroy()
        {
            UIManager.Destroy();
        }

        private void InitUIManager()
        {
            DontDestroyOnLoad(_uiRootCanvas.gameObject);
            UIManager.Create(_uiRootCanvas);
        }

        private void GameStart()
        {
            GameObject player = _resLoader.Load<GameObject>(AssetPathDefine.Player);
            Instantiate(player);

            GameObject enemy = _resLoader.Load<GameObject>(AssetPathDefine.Enemy);
            Instantiate(enemy);
        }
    }
}
