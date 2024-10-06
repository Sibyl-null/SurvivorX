using SurvivorX.UI.Core;

namespace SurvivorX.UI.GameRunning
{
    public class GameRunningPage : GamePage<GameRunningUI>
    {   
        protected override void OnInit()
        {
            base.OnInit();
            UI.TmpExpTmp.text = "经验值：" + Global.Exp.Value;
        }

        protected override void AddEvent()
        {
            base.AddEvent();
            Global.Exp.Register(OnExpChanged);
        }
        
        protected override void RemoveEvent()
        {
            base.RemoveEvent();
            Global.Exp.UnRegister(OnExpChanged);
        }

        private void OnExpChanged(int value)
        {
            UI.TmpExpTmp.text = "经验值：" + value;
        }
    }
}