using UnityEngine;

namespace Nutela.Player
{
    public class PlayerController : IUpdate
    {
        private const string PlayerDataFileName = "PlayerDocument";
        
        private PlayerInput _playerInput;
        private Player _player;
        private PlayerView _playerView;
        private PlayerData _playerData;
        
        public PlayerController()
        {
            
            _playerData = Resources.Load<PlayerData>(PlayerDataFileName);
            _playerInput = new PlayerInput();
            _player = new Player(_playerData);
            Vector3 pos = new Vector3(_playerData.X, _playerData.Y, _playerData.Z);
            _playerView = new PlayerView(_playerData.Prefab.transform, _playerData.Prefab.gameObject, pos);
            
        }
        
        public void NUpdate()
        {
            
        }

        public void NFixedUpdate()
        {
            
        }
    }
}