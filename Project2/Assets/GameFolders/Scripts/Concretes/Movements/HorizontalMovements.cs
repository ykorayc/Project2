using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Controllers;
namespace Project2.Movements
{
    public class HorizontalMovements : MonoBehaviour
    {
        PlayerController _playerController;

        public HorizontalMovements(PlayerController playerController)
        {
            _playerController = playerController;
        }
        public void TickFixed(float horizontal,float moveSpeed)
        {
            if (horizontal == 0) return;
            _playerController.transform.Translate(Vector3.right*horizontal*Time.deltaTime*moveSpeed); //Vector3.right ile carpmakzzorundayiz(- ve + olaylarýnýn duzgun calisabilmesi icin)
        }
    }
}
