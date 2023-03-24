using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Abstracts;
using UnityEngine.SceneManagement;
using Project2.ScriptableObjects;
using Project2.UIs;
namespace Project2.Managers
{
    public class GameManager : SingletonBehaviorObject<GameManager>
    {
        public event System.Action OnGameStop;
        [SerializeField] LevelDifficultyData[] _levelDiffucultyDatas;
        public LevelDifficultyData levelDiffucultyData => _levelDiffucultyDatas[DiffucultyIndex]; //SerializeField objelere diger script'lerden ulasamayiz. Ulasabilmek icin property tanimlamak zorundayiz.!!!!!
        public int diffucultyIndex;
        public int DiffucultyIndex 
        {
            get => diffucultyIndex;
            
            set 
            {
               if(diffucultyIndex < 0 || diffucultyIndex > _levelDiffucultyDatas.Length)
                {
                    LoadScene("Menu");
                }
                else
                {
                    diffucultyIndex = value;
                }
            }
        }
       
        private void Awake()
        {
           SingletonThisGameObject(this);
        }
       
        public void StopGame()
        {
            OnGameStop?.Invoke(); //Bos degilse calistir. Doldurmasini da GameCanvas aktif oldugunda ordaki fonksiyonu ekleyerek yapiyoruz.
            Time.timeScale = 0.0f;
        }
        public void LoadScene(string name)
        {
            StartCoroutine(LoadSceneAsync(name));
        }
        private IEnumerator LoadSceneAsync(string name)
        {
            Time.timeScale = 1.0f; //Bunu demezsek, herhangi bir enemy'e carpmasi sonucunda Time.timeScele 0 old. icin  baslatsak bile duzelmez. Metodta bunu vermemiz gerekir.
            yield return SceneManager.LoadSceneAsync(name);  //SceneManager icerisindeki LoadSceneAsync 'u calistirman lazim.Normal loadSceneAsync degil...!
        }

        public void ExitGame()
        {
            Debug.Log("Exit clicked");
            Application.Quit();
        }
    }

}
