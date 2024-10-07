using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField] float velocidad = 30;
    [SerializeField] int direccion;
    [SerializeField] float temporizador;

    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(new Vector3(0f, 180f, 0f) * Time.deltaTime);
      
    }
}
