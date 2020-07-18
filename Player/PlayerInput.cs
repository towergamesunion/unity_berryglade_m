using UnityEngine;
using Nutela.Utilities;
namespace Nutela.Player
{
    public class PlayerInput
    {
        
        private float _x;
        private float _y;
        private KeyCode _jump;
        
        public float AxisX()
        {
            Debugger.Log(Input.GetAxis("Horizontal"));
            return Input.GetAxis("Horizontal");
        }

        public float AxisY()
        {
            Debugger.Log(Input.GetAxis("Vertical"));
            return Input.GetAxis("Vertical");
        }
    }
}