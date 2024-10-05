using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField] float velocidad = 30;
    [SerializeField] int direccion;
    [SerializeField] float temporizador;
    [SerializeField] float alturaMaxima = 3f;
    [SerializeField] float alturaMinima = 0f;
    [SerializeField] bool subiendo = true;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(new Vector3(0f, 180f, 0f) * Time.deltaTime);
        Vector3 posicion = transform.position;
        if (subiendo)
        {
            posicion.y += velocidad * Time.deltaTime;
            if (posicion.y >= alturaMaxima)
            {
                posicion.y = alturaMaxima;
                subiendo = false;
            }
        }
        else
        {
            posicion.y -= velocidad * Time.deltaTime;
            if (posicion.y <= alturaMinima)
            {
                posicion.y = alturaMinima;
                subiendo = true;
            }
        }
        transform.position = posicion;
    }
}
