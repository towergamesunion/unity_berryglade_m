using System;
using System.Collections.Generic;
using Nutela;
using Nutela.Player;
using UnityEngine;

namespace Core
{
    public class Root : MonoBehaviour
    {
        
        private List<IUpdate> _nUpdates;
        private PlayerController _playerController;

        private void Start()
        {
            _playerController = new PlayerController();
            _nUpdates = new List<IUpdate>();
            _nUpdates.Add(_playerController);
        }

        

        public void Update()
        {
            foreach (var controller in _nUpdates)
            {
                controller.NUpdate();
            }
        }

        public void FixedUpdate()
        {
            foreach (var controller in _nUpdates)
            {
                controller.NFixedUpdate();
            }
        }
    }
}