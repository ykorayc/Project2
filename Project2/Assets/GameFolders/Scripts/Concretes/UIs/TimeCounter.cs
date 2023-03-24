using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Project2.UIs
{
    public class TimeCounter : MonoBehaviour
    {
        TextMeshProUGUI  _textCounter;
        private float _currentTime;

        private void Awake()
        {
            _textCounter = GetComponent<TextMeshProUGUI>();
        }
        private void Update()
        {
            _currentTime += Time.deltaTime;
            _textCounter.text = _currentTime.ToString("0");  //ToString("0") yazmak sadece tam sayi seklini goster demek, fractional kismini gosterme demektir.
        }

    }

}