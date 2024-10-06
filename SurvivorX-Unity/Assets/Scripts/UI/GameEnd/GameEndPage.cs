using SurvivorX.UI.Core;
using UIFramework.Runtime.Page;

namespace SurvivorX.UI.GameEnd
{
    public class GameEndPage : GamePage<GameEndUI>
    {   
        protected override void OnInit()
        {
            base.OnInit();
            UI.BtnReStartBtn.onClick.AddListener(OnReStartClick);
        }

        protected override void OnPrepare(IPageArg arg = null)
        {
            base.OnPrepare(arg);
            UI.TmpEndTmp.text = GameStateController.Instance.CurState == GameState.GameWin ? "游戏胜利" : "游戏失败";
        }

        private void OnReStartClick()
        {
            UIManager.Instance.ClosePage<GameEndPage>();
            GameStateController.Instance.MakeGameStart();
        }
    }
}