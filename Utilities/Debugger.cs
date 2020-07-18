using UnityEngine;

namespace Nutela.Utilities
{
    public class Debugger
    {
        public static void Log(string msg)
        {
            Debug.Log(msg);
        }
        
        public static void Log(float msg)
        {
            Debug.Log(msg);
        }
        
        public static void Log(string msg, float arg)
        {
            Debug.Log(msg + arg);
        }
    }
}