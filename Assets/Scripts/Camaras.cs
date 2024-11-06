using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camaras : MonoBehaviour
{
    [SerializeField] private GameObject cam1;
    //[SerializeField] private GameObject camVoltear;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if (cam1.activeSelf)
            {
                cam1.SetActive(false);
                //camVoltear.SetActive(true);

            }
            else
            {
                cam1.SetActive(true);
               // camVoltear.SetActive(false);
            }
        }

    }
}
