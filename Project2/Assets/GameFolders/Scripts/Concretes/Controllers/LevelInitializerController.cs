using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.ScriptableObjects;
using Project2.Managers;
using Project2.Controllers;
namespace Project2.Controllers
{
    
    public class LevelInitializerController : MonoBehaviour
    {
        LevelDifficultyData _levelDifficultyData;

        private void Awake()
        {
            _levelDifficultyData = GameManager._instance.levelDiffucultyData;
        }
        private void Start()
        {
            RenderSettings.skybox = _levelDifficultyData.skyboxMaterial; //Skybox'a scriptten ulasabilmek icin RenderSettings.Skybox'u kullaniriz.
            Instantiate(_levelDifficultyData.spawner);
            Instantiate(_levelDifficultyData.floorController);
        }
    }
}
