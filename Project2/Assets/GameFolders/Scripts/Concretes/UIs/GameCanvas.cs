using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Managers;
namespace Project2.UIs
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameOverPanel _gameOverPanel;
        private void Awake()
        {
            _gameOverPanel.gameObject.SetActive(false);
        }
        private void OnEnable()
        {
            GameManager._instance.OnGameStop += HandleOnGameStop;  //Olay su: GameCanvas Enable oldugunda OnGameStop event'ine HandleOnGameStop eklenmis oluyor. Bu event ise GameManager icerisinde oyun durduruldugunda calis
        }
        private void OnDisable()
        {
            GameManager._instance.OnGameStop -= HandleOnGameStop;
        }
        private void HandleOnGameStop()
        {
            _gameOverPanel.gameObject.SetActive(true); //Oyun stoplaninca true olmasini istiyoruz.
        }

    }

}
