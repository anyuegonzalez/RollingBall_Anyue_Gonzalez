using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotacion : MonoBehaviour
{
    [SerializeField] float velocidad = 30;
    [SerializeField] int direccion;
    public float alturaMovimiento = 9f; 
    public float duracion = 2.0f; 

    private Vector3 posicionInicial; 
    private bool subiendo = true; 
    private float temporizador = 0f; 


    void Start()
    {
        posicionInicial = transform.position;

    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 200 * Time.deltaTime, Space.World);
        
        temporizador += Time.deltaTime;
        if (temporizador >= duracion)
        {
            
            subiendo = !subiendo;
            temporizador = 0f; 
        }
        float mov = temporizador / duracion;

        float nuevaY = posicionInicial.y + Mathf.PingPong(Time.time * velocidad, alturaMovimiento); // esta linea es para mov ciclicos de un objeto
        transform.position = new Vector3(posicionInicial.x, nuevaY, posicionInicial.z);

    }
}
