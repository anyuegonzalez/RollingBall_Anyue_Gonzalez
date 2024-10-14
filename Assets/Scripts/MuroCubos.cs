using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroCubos : MonoBehaviour
{
 
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.3f;
        }
    }
}
