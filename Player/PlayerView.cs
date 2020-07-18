using UnityEngine;
using Nutela.Utilities;
namespace Nutela.Player
{
    public class PlayerView
    {
        private Transform _transform;
        private GameObject _gameObject;
        
        public PlayerView(
            GameObject gameObj,
            Vector3 position)
        {
            
            _gameObject = UnityEngine.Object.Instantiate(gameObj);
            _transform = _gameObject.transform;
            
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
            float deltaTime)
        {
            float hAxis = x * speed * lateralSpeed * deltaTime;
            float vAxis = y * speed * deltaTime;
            Vector3 velocity = new Vector3(hAxis, 0, vAxis);
            Vector3 startPos = _transform.position;
            Vector3 endPos = startPos + velocity;
            Vector3 resultPos = Lerp.LerpPosition(startPos, endPos, 0.33f);
            _transform.position = resultPos;
            
        }
    }   
}
