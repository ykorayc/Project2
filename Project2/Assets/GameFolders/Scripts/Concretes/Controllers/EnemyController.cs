using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Movements;
namespace Project2.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] float maxLifeTime;
        VerticalMover _verticalMover;
        [SerializeField] float enemyMoveSpeed;
        public float _enemyMoveSpeed => enemyMoveSpeed;
        float currentLifeTime=0.0f;
        private void Awake()
        {
            _verticalMover = new VerticalMover(this);
        }
        private void Update()
        {
            currentLifeTime += Time.deltaTime;  //Saniye saniye arttirir.
            Debug.Log(currentLifeTime);
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
            Destroy(this.gameObject);
        }

    }

}
