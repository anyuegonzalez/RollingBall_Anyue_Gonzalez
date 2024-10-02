using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        transform.Rotate(new Vector3(0f, 180f, 0f) * Time.deltaTime);
       
    }
}
