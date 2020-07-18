using UnityEngine;
namespace Nutela.Player
{
    public class PlayerInput
    {
        
        private float _x;
        private float _y;
        private KeyCode _jump;
        
        public float AxisX()
        {
            return Input.GetAxis("Horizontal");
        }

        public float AxisY()
        {
            return Input.GetAxis("Horizontal");
        }
    }
}