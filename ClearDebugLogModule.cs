using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearDebugLog
{
    public class ClearDebugLogModule : ETGModule
    {
        public override void Init()
        {
        }

        public override void Start()
        {
            ETGModConsole.Commands.AddUnit("clear_debug", this.ClearDebugLog);
            ETGModConsole.Log("Clear Debug Log started successfully. Use <color=#ff0000>clear_debug</color> to clear the debug log.");
        }

        public void ClearDebugLog(string[] args)
        {
            ETGModDebugLogClearer.ClearDebugLog();
        }

        public override void Exit()
        {
        }
    }

    public class ETGModDebugLogClearer : ETGModDebugLogMenu
    {
        public static void ClearDebugLog()
        {
            List<LoggedText> listOfText = _AllLoggedText;
            if(Instance != null)
            {
                Instance.GUI.Children.Clear();
            }
            listOfText.Clear();
            _LoggedTextAddIndex = 0;
        }
    }
}
