using SurvivorX.UI.Core;
using UnityEngine;

namespace SurvivorX
{
    public class Launcher : MonoBehaviour
    {
        [SerializeField] private Canvas _uiRootCanvas;

        private void Start()
        {
            InitUIManager();
            GameStateController.Instance.MakeGameStart();
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
    }
}
