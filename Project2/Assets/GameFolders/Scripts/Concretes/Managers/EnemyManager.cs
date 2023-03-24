using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Managers;
using Project2.Controllers;
using Project2.Abstracts;
namespace Project2.Managers
{
    public class EnemyManager : SingletonBehaviorObject<EnemyManager>
    {
        [SerializeField] EnemyController[] _enemyPrefab;
        Queue<EnemyController> enemies = new Queue<EnemyController>(); //FIFO   h,e,l,l,o enqueue ettiginde dequeue etttiginde cikan yine h,e,l,l,o olur.

        private void Awake()
        {
            SingletonThisGameObject(this);
        }
        private void Start()
        {
            InitializePool();   
        }
        public void InitializePool()
        {
            for(int i=0;i<10;i++)
            {
                EnemyController _newEnemy= Instantiate(_enemyPrefab[Random.Range(0,_enemyPrefab.Length)]);
                _newEnemy.gameObject.SetActive(false);//Ilk calistirildiginda aktifliinin false olmasini istiyorum.
                _newEnemy.transform.parent = this.transform;
                enemies.Enqueue(_newEnemy);
            }
        }
        public void SetPool(EnemyController _enemyController)
        {
            _enemyController.gameObject.SetActive(false);
            _enemyController.transform.parent = this.transform;
            enemies.Enqueue(_enemyController);
        }
        public EnemyController GetPool()
        {
            if(enemies.Count==0) //Bu kod parcacigi sayesinde hicbir zaman pool'umuzda objeler tukenmeyecek, tukenmeye yakin 10 adet daha uretilecek.
            {
                InitializePool();
            }
            return enemies.Dequeue();
        }

    }

}