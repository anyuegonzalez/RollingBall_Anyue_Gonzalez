using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotacion : MonoBehaviour
{
    [SerializeField] float velocidad = 30;
    [SerializeField] int direccion;
    // [SerializeField] float temporizador;

    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 200 * Time.deltaTime, Space.World);

    }
}
