using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillos_Golpeadores : MonoBehaviour
{
    [SerializeField] int fuerzaGolpe = 500;
    [SerializeField] Vector3 direccionR;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(direccionR* fuerzaGolpe, ForceMode.Impulse);
    }
    void Update()
    {
        // transform.Rotate(new Vector3(0, 1, 0) * 500 * Time.deltaTime, Space.World);
    }
}
