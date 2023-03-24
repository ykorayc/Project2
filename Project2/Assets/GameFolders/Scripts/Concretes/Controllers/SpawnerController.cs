using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Managers;

namespace Project2.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
     

        [Range(.1f,6f)]
        [SerializeField] float minVal=.1f;
        
        [Range(6f, 15f)]
        [SerializeField] float maxVal = 15f;

        float currentSpawnTime=0f;
        [SerializeField] float maxSpawnTime;

        private void OnEnable()
        {
            GetRandomMaxTime();
        }
        private void Update()
        {
            currentSpawnTime += Time.deltaTime;
            if(currentSpawnTime>maxSpawnTime)
            {
                Spawn();
            }
            
        }
        void Spawn()
        {
            EnemyController newEnemy = EnemyManager._instance.GetPool();

            newEnemy.gameObject.SetActive(true);
            newEnemy.transform.parent = this.gameObject.transform;
            newEnemy.transform.position = this.transform.position;

            currentSpawnTime = 0;
            GetRandomMaxTime();
        }
        void GetRandomMaxTime()
        {
            maxSpawnTime = Random.Range(minVal,maxVal);
        }


     }

}
