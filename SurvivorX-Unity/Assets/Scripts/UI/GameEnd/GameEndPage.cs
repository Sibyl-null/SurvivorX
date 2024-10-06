using SurvivorX.UI.Core;

namespace SurvivorX.UI.GameEnd
{
    public class GameEndPage : GamePage<GameEndUI>
    {   
        protected override void OnInit()
        {
            base.OnInit();
            UI.BtnReStartBtn.onClick.AddListener(OnReStartClick);
        }

        private void OnReStartClick()
        {
            Launcher.Instance.GameStart();
            UIManager.Instance.ClosePage<GameEndPage>();
        }
    }
}