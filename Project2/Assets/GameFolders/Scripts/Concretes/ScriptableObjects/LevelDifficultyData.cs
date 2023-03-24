using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Controllers;
namespace Project2.ScriptableObjects
{
    [CreateAssetMenu(fileName ="Level Difficulty",menuName ="Create Difficulty/Create NEW",order =1)]
    public class LevelDifficultyData : ScriptableObject
    {
        //ScriptabeObject'ler datalarý tutmak icin kullanilir.
        [SerializeField] FloorController _floorController;
        [SerializeField] GameObject _spawner;
        [SerializeField] Material _skyboxMaterial;
        [SerializeField] float _moveSpeedEnemy;
        //Property'leri tanimladik, cunku yukarida yaptigimiz herhangi bir degisiklikte eger property tanimlamasaydik, hepsi degisecekti. Bu sayede 
        public FloorController floorController=> _floorController;
        public GameObject spawner => _spawner;
        public Material skyboxMaterial => _skyboxMaterial;
        public float moveSpeedEnemy => _moveSpeedEnemy;
    }

}