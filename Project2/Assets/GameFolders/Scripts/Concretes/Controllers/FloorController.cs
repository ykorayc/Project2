using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project2.Controllers
{
    public class FloorController : MonoBehaviour
    {
        [Range(.5f,2f)]
        [SerializeField] float floorMoveSpeed;
        Material _material;

        private void Awake()
        {
            _material = GetComponentInChildren<MeshRenderer>().material;

        }
        private void Update()
        {
            _material.mainTextureOffset += Vector2.down * Time.deltaTime * floorMoveSpeed;
        }

    }

}
