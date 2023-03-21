using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Movements;

namespace Project2.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _horizontalDirection=0f;
        [SerializeField] float moveSpeed = 10f;
        HorizontalMovements _horizontalMovements;
        JumpWithRigidbody _jumpWithRigidbody;
        [SerializeField] private float _jumpForce;
        [SerializeField] private bool isJump;
        private void Awake()
        {
            _horizontalMovements = new HorizontalMovements(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);    
        }
        private void FixedUpdate()
        {
            _horizontalMovements.TickFixed(_horizontalDirection,moveSpeed);


            if (isJump) 
            {
                _jumpWithRigidbody.TicFixed(_jumpForce);
                //isJump = false;//Direk olarak isJump bool deðerini false'a çevirmiþ oluruz ve saliselik olarak zýplamalar yapmýþ oluruz. Bunun yerine if blogunun disarisinda isJump fonksiyonunun aktifligini pasif hale getirmemiz gerekir.
            }
            isJump = false;
              
          
        }
    }
}

