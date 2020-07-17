using UnityEngine;
namespace Nutela.Player
{
    public class PlayerInput
    {
        private float _h;
        private float _v;
        private KeyCode _jump;
        
        public float H
        {
            get => _h;
            set => _h = value;
        }

        public float V
        {
            get => _v;
            set => _v = value;
        }

        

    }
}