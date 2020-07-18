using UnityEngine;
using Nutela.Utilities;
namespace Nutela.Player
{
    public class PlayerView
    {
        private Transform _transform;
        private GameObject _gameObject;
        
        public PlayerView(
            Transform playerTransform, 
            GameObject gameObj,
            Vector3 position)
        {
            
            _transform = playerTransform;
            _gameObject = gameObj;
            if (_transform != null)
            {
                _transform.position = position;
            }
             

        }
        
        public void Move(
            float x, 
            float y, 
            float speed, 
            float lateralSpeed,
            float deltaTime,
            Transform t)
        {
            Vector3 velocity = new Vector3(x * speed * lateralSpeed * deltaTime, y * speed * deltaTime, 0);
            Vector3 startPos = t.position;
            Vector3 endPos = startPos + velocity;
            Vector3 resultPos = Lerp.LerpPosition(startPos, endPos, 0.33f);
            _transform.position = resultPos;
            
        }
    }   
}
