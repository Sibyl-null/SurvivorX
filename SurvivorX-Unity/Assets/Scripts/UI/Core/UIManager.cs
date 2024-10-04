using QFramework;
using UIFramework.Runtime;
using UIFramework.Runtime.Utility;
using UnityEngine;

namespace SurvivorX.UI.Core
{
    public partial class UIManager : AbstractUIManager
    {
        public static UIManager Instance { get; private set; }
        private static IUnRegister _register;
        
        public static void Create(Canvas canvas)
        {
            if (Instance != null)
            {
                UILogger.Error("[UI] UIManager has already been created");
                return;
            }
            
            Instance = new UIManager();
            Instance.InitInternal(canvas, new UIResLoader());
            Instance.LoadInfos();

            UIUtility.SetUILayerLogger(order => Instance.Settings.GetLayerName(order));

            _register = ActionKit.OnUpdate.Register(OnUpdate);
        }

        public static void Destroy()
        {
            _register.UnRegister();
            _register = null;
            
            Instance.ReleaseInternal();
            Instance = null;
        }
        
        private static void OnUpdate()
        {
            Instance.Tick();

            if (Input.GetKeyDown(KeyCode.Escape))
                Instance.ReceiveEscape();
        }
    }
}
