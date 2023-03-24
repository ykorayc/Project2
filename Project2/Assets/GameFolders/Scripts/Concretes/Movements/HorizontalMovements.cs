using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Controllers;
namespace Project2.Movements
{
    public class HorizontalMovements : MonoBehaviour
    {
        PlayerController _playerController;
        float moveSpeed;
        float moveBoundary;

        public HorizontalMovements(PlayerController playerController)
        {
            _playerController = playerController;
            moveSpeed = playerController._moveSpeed;
            moveBoundary = playerController._moveBoundary;
        }
        public void FixedTick(float horizontal)
        {
            if (horizontal == 0) return;
            _playerController.transform.Translate(Vector3.right*horizontal*Time.deltaTime*moveSpeed); //Vector3.right ile carpmakzzorundayiz(- ve + olaylarýnýn duzgun calisabilmesi icin)
            float xboundary = Mathf.Clamp(_playerController.transform.position.x, -moveBoundary, moveBoundary);
            _playerController.transform.position = new Vector3(xboundary, _playerController.transform.position.y, 0);
        }
    }
}
