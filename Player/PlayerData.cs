
using UnityEngine;

namespace Nutela.Player
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerData", order = 4)] 
    public class PlayerData : ScriptableObject
    {
        [SerializeField] private string _playerName;
        [SerializeField] private float _speed;
        [SerializeField] private float _lateralSpeed;
        [Header("Position")] 
        [SerializeField] private float _x, _y, _z;

        [SerializeField] private GameObject _prefab;

        public GameObject Prefab
        {
            get => _prefab;
            
        }

        public float X
        {
            get => _x;
            
        }

        public float Y
        {
            get => _y;
            
        }

        public float Z
        {
            get => _z;
            
        }

        public string PlayerName
        {
            get => _playerName;
            
        }

        public float Speed
        {
            get => _speed;
           
        }

        public float LateralSpeed
        {
            get => _lateralSpeed;
        
        }
    }   
}
