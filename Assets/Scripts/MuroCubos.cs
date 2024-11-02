using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroCubos : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rbs;
    [SerializeField] GameObject manager;

    private float timer = 0f;
    private bool iniciarCuenta = false;
 
    void Start()
    {
        
    }

    
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
            Time.timeScale = 0.3f;
            iniciarCuenta = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Player"))
        {
            manager.GetComponent<Bola>().Puntos += 5;
        }
    }
}
