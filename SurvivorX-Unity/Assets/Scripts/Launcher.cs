using QFramework;
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
        
        public static Launcher Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            InitUIManager();
            GameStart();
        }

        private void OnDestroy()
        {
            UIManager.Destroy();
            Instance = null;
        }

        private void InitUIManager()
        {
            DontDestroyOnLoad(_uiRootCanvas.gameObject);
            UIManager.Create(_uiRootCanvas);
        }

        public void GameStart()
        {
            GameClearActors();
            
            GameObject player = _resLoader.Load<GameObject>(AssetPathDefine.Player);
            Instantiate(player);

            GameObject enemy = _resLoader.Load<GameObject>(AssetPathDefine.Enemy);
            Instantiate(enemy);
        }

        private void GameClearActors()
        {
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
            players.ForEach(Destroy);
            
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            enemies.ForEach(Destroy);
        }
    }
}
