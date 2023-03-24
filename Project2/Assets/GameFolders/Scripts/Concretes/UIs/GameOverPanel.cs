using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Managers;
using UnityEngine.SceneManagement;
namespace Project2.UIs
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager._instance.LoadScene("Game");
        }
        public void NoButton()
        {
            GameManager._instance.LoadScene("Menu");
        }
    }

}
