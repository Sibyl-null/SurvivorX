using SurvivorX.UI.Core;
using UIFramework.Runtime.Page;

namespace SurvivorX.UI.GameEnd
{
    public class GameEndPage : GamePage<GameEndUI>
    {   
        public struct Arg : IPageArg
        {
            public bool IsWin;
        }
        
        protected override void OnInit()
        {
            base.OnInit();
            UI.BtnReStartBtn.onClick.AddListener(OnReStartClick);
        }

        protected override void OnPrepare(IPageArg arg = null)
        {
            base.OnPrepare(arg);
            Arg args = (Arg)arg;
            UI.TmpEndTmp.text = args.IsWin ? "游戏胜利" : "游戏失败";
        }

        private void OnReStartClick()
        {
            Launcher.Instance.GameStart();
            UIManager.Instance.ClosePage<GameEndPage>();
        }
    }
}