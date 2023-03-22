using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Project2.Abstracts
{
    public abstract class SingletonBehaviorObject<T> :MonoBehaviour where T:Component //interface'lerin parentleri olamaz fakat abstract class'lar parent alabilir.Ondan dolayi abstract class kullaniriz.(Tekrar et.)
    { //Abstract class'lar new'lenemez, sadece miras verebilir.

        public static T _instance { get; private set; }
        
           protected void SingletonThisGameObject(T entity)
            {
            if (_instance==null)
            {
                _instance = entity;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

    }

}
