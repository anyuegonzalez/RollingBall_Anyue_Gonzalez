using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject camTop;
    private void Start()
    {
        camTop.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {

                cam1.SetActive(false);
                camTop.SetActive(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cam1.SetActive(true);
            camTop.SetActive(false);

        }
        
    }
}
