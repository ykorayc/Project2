using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Abstracts;
using UnityEngine.SceneManagement;
namespace Project2.Managers
{
    public class GameManager : SingletonBehaviorObject<GameManager>
    {
        private void Awake()
        {
           SingletonThisGameObject(this);
        }
        public void StopGame()
        {
            Time.timeScale = 0.0f;
        }
        public void LoadScene(string name)
        {
            StartCoroutine(LoadSceneAsync(name));
        }
        private IEnumerator LoadSceneAsync(string name)
        {
            Time.timeScale = 1f; //Bunu demezsek, herhangi bir enemy'e carpmasi sonucunda Time.timeScele 0 old. icin  baslatsak bile duzelmez. Metodta bunu vermemiz gerekir.
            yield return SceneManager.LoadSceneAsync(name);  //SceneManager icerisindeki LoadSceneAsync 'u calistirman lazim.Normal loadSceneAsync degil...!
        }

        public void ExitGame()
        {
            Debug.Log("Exit clicked");
            Application.Quit();
        }
    }

}
