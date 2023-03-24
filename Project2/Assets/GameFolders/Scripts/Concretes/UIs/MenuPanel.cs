using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Managers;
namespace Project2.UIs
{
    public class MenuPanel : MonoBehaviour
    {
        public void SelectAndStart(int index)
        {
            GameManager._instance.diffucultyIndex = index;
            GameManager._instance.LoadScene("Game");
        }

        public void ExitButton()
        {
            GameManager._instance.ExitGame();
        }
        

    }

}