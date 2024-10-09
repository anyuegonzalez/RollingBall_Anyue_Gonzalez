using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataformas : MonoBehaviour
{
    [SerializeField] Vector3 direccionR;
    Rigidbody rb;
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(direccionR * 20, ForceMode.VelocityChange);
    }
}
