using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    [SerializeField] Vector3 direccion = new Vector3(0,0,0);
    [SerializeField] float velocidad = 12f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        //transform.Translate(new Vector3(h,v), Space.World);
        Salto();

    }
    void Salto()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(direccion * 12, ForceMode.Force);
        }
    }
    // bola en todas las direcciones teclas axis con una fuerza constante, impulse y FORCE

}
