namespace Nutela.Player
{
    public class PlayerController : IUpdate
    {
        private PlayerInput _playerInput;
        private Player _player;
        private PlayerView _playerView;
        
        public PlayerController()
        {
            _playerInput = new PlayerInput();
        }
        
        public void NUpdate()
        {
            
        }

        public void NFixedUpdate()
        {
            
        }
    }
}