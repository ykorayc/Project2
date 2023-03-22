using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project2.Controllers
{
    public class SpawnerController : MonoBehaviour
    {
        [SerializeField] EnemyController _enemyPrefab;

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
            EnemyController _enemyController= Instantiate(_enemyPrefab, transform.position, transform.rotation); //Instantiate edilmis olan prefab'in uretildigi spawner'in child'i olmasini istedigimiz icin bir obje olusturduk.

            _enemyController.transform.parent = this.gameObject.transform;
            currentSpawnTime = 0;
            GetRandomMaxTime();
        }
        void GetRandomMaxTime()
        {
            maxSpawnTime = Random.Range(minVal,maxVal);
        }


     }

}
