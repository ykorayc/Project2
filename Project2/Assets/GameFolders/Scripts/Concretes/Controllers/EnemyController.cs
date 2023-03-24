using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Movements;
using Project2.Managers;
using Project2.Abstracts.Controllers;
using Project2.ScriptableObjects;
namespace Project2.Controllers
{
    public class EnemyController : MonoBehaviour   // IEntityController'dan kalýttýk.
    {
        [SerializeField] float maxLifeTime;
        VerticalMover _verticalMover;
        // [SerializeField] float enemyMoveSpeed;
        // float _enemyMoveSpeed => enemyMoveSpeed;
        public float enemyMoveSpeed;
        float currentLifeTime=0.0f;
        private void Awake()
        {
            _verticalMover = new VerticalMover(this);
            
        }
        private void Start()
        {
            enemyMoveSpeed = GameManager._instance.levelDiffucultyData.moveSpeedEnemy;
        }
        private void Update()
        {
            currentLifeTime += Time.deltaTime;  //Saniye saniye arttirir.
            if (currentLifeTime > maxLifeTime)
            {
                currentLifeTime = 0f;
                KillYourself();
            }
        }
        private void FixedUpdate()
        {
            _verticalMover.FixedTick();
        }
        void KillYourself()
        {
            EnemyManager._instance.SetPool(this);
        }

    }

}
