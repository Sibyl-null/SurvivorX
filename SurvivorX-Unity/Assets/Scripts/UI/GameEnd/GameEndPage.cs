using SurvivorX.UI.Core;

namespace SurvivorX.UI.GameEnd
{
    public class GameEndPage : GamePage<GameEndUI>
    {   
        protected override void OnInit()
        {
            base.OnInit();
            UI.TmpEndTmp.text = GameStateController.Instance.CurState == GameState.GameWin ? "游戏胜利" : "游戏失败";
            UI.BtnReStartBtn.onClick.AddListener(OnReStartClick);
        }

        private void OnReStartClick()
        {
            UIManager.Instance.ClosePage<GameEndPage>();
            GameStateController.Instance.MakeGameStart();
        }
    }
}