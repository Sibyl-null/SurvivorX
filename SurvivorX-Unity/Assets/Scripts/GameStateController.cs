using JetBrains.Annotations;
using QFramework;
using SurvivorX.Actors;
using SurvivorX.UI.Core;
using SurvivorX.UI.GameEnd;
using SurvivorX.UI.GameRunning;
using SurvivorX.Util.Defines;
using SurvivorX.Util.ResLoaders;
using UnityEngine;

namespace SurvivorX
{
    public enum GameState
    {
        WaitStart,
        GameRunning,
        GameWin,
        GameFail
    }
    
    [UsedImplicitly]
    public class GameStateController : Singleton<GameStateController>
    {
        public GameState CurState { get; private set; }

        private readonly IResLoader _resLoader = ResLoader.Instance;

        private GameStateController()
        {
        }
        
        public void MakeGameStart()
        {
            CurState = GameState.GameRunning;
            GameClearActors();
            
            GameObject player = _resLoader.Load<GameObject>(AssetPathDefine.Player);
            Object.Instantiate(player);

            GameObject enemy = _resLoader.Load<GameObject>(AssetPathDefine.Enemy);
            enemy.Instantiate()
                .GetComponent<Enemy>()
                .Init(player.transform);
            
            UIManager.Instance.OpenPage<GameRunningPage>();
        }
        
        private void GameClearActors()
        {
            GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
            players.ForEach(Object.Destroy);
            
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            enemies.ForEach(Object.Destroy);
        }

        public void MakeGameWin()
        {
            CurState = GameState.GameWin;
            UIManager.Instance.OpenPage<GameEndPage>();
        }

        public void MakeGameFail()
        {
            CurState = GameState.GameFail;
            UIManager.Instance.OpenPage<GameEndPage>();
        }
    }
}