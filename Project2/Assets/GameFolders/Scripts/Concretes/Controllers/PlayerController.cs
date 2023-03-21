using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project2.Movements;
using Project2.Abstracts.Inputs;
using UnityEngine.InputSystem;
using Project2.Inputs;
namespace Project2.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 20f;
        HorizontalMovements _horizontalMovements;
        JumpWithRigidbody _jumpWithRigidbody;
        [SerializeField] private float _jumpForce;
        [SerializeField] private bool isJump;
        
        IInputReader _input;
        float _horizontal;

        private void Awake()
        {
            _horizontalMovements = new HorizontalMovements(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }
        private void Update() //Inputlarý update metodunda okuruz. 
        {
            _horizontal = _input.horizontal;
            
        }
        private void FixedUpdate()
        {
            _horizontalMovements.TickFixed(_horizontal,moveSpeed);


            if (isJump) 
            {
                _jumpWithRigidbody.TicFixed(_jumpForce);
                //isJump = false;//Direk olarak isJump bool deðerini false'a çevirmiþ oluruz ve saliselik olarak zýplamalar yapmýþ oluruz. Bunun yerine if blogunun disarisinda isJump fonksiyonunun aktifligini pasif hale getirmemiz gerekir.
            }
            isJump = false;
              
          
        }
    }
}

