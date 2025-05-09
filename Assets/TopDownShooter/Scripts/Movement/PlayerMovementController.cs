using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;
namespace TopDownShooter.PlayerMovement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private InputData _inputData;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;
        private void Update()
        {
            _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.forward * _inputData.Vertical * _playerMovementSettings.VerticalSpeed));
            _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.right * _inputData.Horizontal * _playerMovementSettings.HorizontalSpeed));

            if(_inputData.Jump)
            {
                _rigidbody.AddForce(_playerMovementSettings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}
