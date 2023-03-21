using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Project2.Abstracts.Inputs;
namespace Project2.Inputs
{

    public class InputReader : IInputReader
    {
        PlayerInput playerInput;
        public float horizontal { get;private set ; }

        public InputReader(PlayerInput _playerInput)
        {
            playerInput = _playerInput;
            playerInput.currentActionMap.actions[0].performed += OnHorizontalMove; //Player Inputtaki Default Map-->Action Map'tir. [0] dememiz gameInput asset'inin icerisindeki 1.'yi acmamizi saglar.
        }

       

        void OnHorizontalMove(InputAction.CallbackContext context)
        {
            horizontal = context.ReadValue<float>();
        }
         
    }

}
