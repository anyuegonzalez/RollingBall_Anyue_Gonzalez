using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource spotify; //spotify

    public void ReproducirSonido(AudioClip clip)
    {
        // ejecuta el clip introducido por parametro de entrada
       spotify.PlayOneShot(clip);
    }
}
