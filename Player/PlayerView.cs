using UnityEngine;
namespace Nutela.Player
{
    public class PlayerView
    {
        private Transform _transform;
        private GameObject _gameObject;
        
        public PlayerView(Transform playerTransform, GameObject gameObj)
        {
            
            this._transform = playerTransform;
            this._gameObject = gameObj;
            
        }
        
        public void Move(float x, float y, float speed, float lateralSpeed, Transform t)
        {
            
        }
    }   
}
