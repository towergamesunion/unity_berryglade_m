using UnityEngine;



namespace Nutela.Player
{
    public class Player
    {
        private float _speed;
        private float _lateralSpeed;
        private string _name;
        private Vector3 _position;
        private PlayerData _playerData;

        public float Speed => _speed;

        public float LateralSpeed => _lateralSpeed;

        public string Name => _name;

        public Vector3 Position => _position;

        public PlayerData PlayerData => _playerData;

        public Player(PlayerData data)
        {
            _name = data.PlayerName;
            _speed = data.Speed;
            _lateralSpeed = data.LateralSpeed;
            _position = new Vector3(data.X, data.Y, data.Z);
        }
        
    }
}

