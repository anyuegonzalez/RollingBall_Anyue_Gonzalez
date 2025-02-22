using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroCubos : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rbs;
    [SerializeField] float temporizador;

    private float timer = 0f;
    private bool iniciarCuenta = false;
 
    void Update()
    {
        
        if (iniciarCuenta) 
        {
            timer += 1 * Time.unscaledDeltaTime;
            if(timer >= 2)
            {

                Time.timeScale = 1f;
                for (int i = 0; i < rbs.Length ; i++) // i = 0... 79
                {
                    rbs[i].useGravity = true;
                }

            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = temporizador;
            iniciarCuenta = true;
        }
    }
   
}
