using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Controllers;
namespace Project2.Movements
{
    public class JumpWithRigidbody : MonoBehaviour
    {
        Rigidbody _rigidbody;
        public bool canJump => _rigidbody.velocity.y != 0;

        public JumpWithRigidbody(PlayerController _playerController)
        {
            _rigidbody = _playerController.GetComponent<Rigidbody>();
        }
        public void TicFixed(float jumpForce)
        {
            if (canJump) return;

            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(Vector3.up*Time.deltaTime*jumpForce);
        }
    }

}
