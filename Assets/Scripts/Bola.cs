using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    [SerializeField] Vector3 direccion = new Vector3(0,0,0);
    [SerializeField] float fuerza = 12f, h, v;
    [SerializeField] float fuerzaSalto = 15f, velocidad = 7f, fuerzaMovimiento =  15f;  
    private bool isGrounded = true;
    

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {
         h = Input.GetAxisRaw("Horizontal");
         v = Input.GetAxisRaw("Vertical");

        Salto();
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(h, 0, v).normalized * fuerzaMovimiento, ForceMode.Force);
    }
    void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("He atravesado un cubo");
    }
}
