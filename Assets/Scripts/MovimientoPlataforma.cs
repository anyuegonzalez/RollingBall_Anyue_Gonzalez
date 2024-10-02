using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataforma : MonoBehaviour
{
    [SerializeField] float velocidad = 30;
    [SerializeField] Vector3 direccion;
    [SerializeField] int tiempo;
    [SerializeField] float timer = 0;
    void Start()
    {
       direccion.Normalize();
    
    }
    void Update()
    {
        if (timer >= 0)
        {
            transform.Translate(direccion = new Vector3(12, 0, 0) * velocidad * Time.deltaTime);
            
        }
        if (timer <= 5)
        {
            transform.Translate(direccion = new Vector3(12, 0, 0) * -1 * velocidad * Time.deltaTime);
            timer = 0; 
        }  
    }
    void cambioDireccion()
    {
        direccion = -direccion;
    }
}
