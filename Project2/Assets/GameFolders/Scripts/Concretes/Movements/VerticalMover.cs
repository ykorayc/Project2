using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Controllers;
namespace Project2.Movements
{
    public class VerticalMover
    {
        EnemyController _enemyController;
        float _enemyMoveSpeed;
        public VerticalMover(EnemyController enemyController)
        {
            _enemyController = enemyController;
            _enemyMoveSpeed = _enemyController._enemyMoveSpeed;
        }

        public void FixedTick(float vertical=1)
        {
            _enemyController.transform.Translate(Vector3.forward*Time.deltaTime*vertical*_enemyMoveSpeed);
        }
    }
}
