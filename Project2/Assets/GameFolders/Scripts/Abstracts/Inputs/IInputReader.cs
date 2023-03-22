using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project2.Abstracts.Inputs
{
    public interface IInputReader
    {
         float horizontal { get; } //public olamaz, cunku interface'lerin access modifier'larý olamaz.Cagirildigi yerde de access modifier kullanirsan sikinti cikabiliyor.Dene sonradan.
         bool  isJump{ get; }
    }

}
