using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{

    [SerializeField] Vector3 direccion;
    [SerializeField] Vector3 movimiento;
    [SerializeField] float velocidad = 12f;

    void Start()
    {
        movimiento.Normalize();
    }

   
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        transform.Translate(direccion = new Vector3(0, 0, 0) * velocidad * Time.deltaTime, Space.World);
    }
}
