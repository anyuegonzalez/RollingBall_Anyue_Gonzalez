using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataforma : MonoBehaviour
{
    [SerializeField] float velocidad = 30;
   // [SerializeField] Vector3 direccion;
    [SerializeField] int tiempo;
    [SerializeField] int direccion;
    [SerializeField] float timer = 0;
    void Start()
    {
    
    }
    void Update()
    {
        Movimiento();
    }
    void Movimiento()
    {
       
        if (direccion == 0)
        {
            transform.position += new Vector3(velocidad * Time.deltaTime, 0, 0);
        }
        else if (direccion == 1)
        {
            transform.position += new Vector3(-velocidad * Time.deltaTime, 0, 0);
        }
    
        if (transform.position.x >= 20)
        {
            direccion = 1;
        }
        if (transform.position.x <= -20)
        {
            direccion = 0;
        }

    }
}
