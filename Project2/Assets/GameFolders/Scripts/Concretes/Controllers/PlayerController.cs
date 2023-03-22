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
        [SerializeField] float moveBoundary;
        [SerializeField] float moveSpeed ;
        public float _moveSpeed => moveSpeed;
        HorizontalMovements _horizontalMovements;
        JumpWithRigidbody _jumpWithRigidbody;
        [SerializeField] private float _jumpForce;
        
        private bool isJump;
        
        IInputReader _input;
        float _horizontal;
        public float _moveBoundary => moveBoundary;

        private void Awake()
        {
            _horizontalMovements = new HorizontalMovements(this);
            _jumpWithRigidbody = new JumpWithRigidbody(this);
            _input = new InputReader(GetComponent<PlayerInput>());
        }
        private void Update() //Inputlarý update metodunda okuruz. 
        {
            _horizontal = _input.horizontal;
            if (_input.isJump)
            {
                isJump = true;
            }
            
            Debug.Log(isJump);
        }
        private void FixedUpdate()
        {
            _horizontalMovements.TickFixed(_horizontal);


            if (isJump) 
            {
                _jumpWithRigidbody.TicFixed(_jumpForce);
                //isJump = false;//Direk olarak isJump bool deðerini false'a çevirmiþ oluruz ve saliselik olarak zýplamalar yapmýþ oluruz. Bunun yerine if blogunun disarisinda isJump fonksiyonunun aktifligini pasif hale getirmemiz gerekir.
            }
            isJump = false;
              
          
        }
    }
}

