using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    [SerializeField] Vector3 direccion = new Vector3(0,0,0);
    [SerializeField] float velocidad = 12f;

    void Start()
    {

    }

   
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(h,v), Space.World);

    }
}
