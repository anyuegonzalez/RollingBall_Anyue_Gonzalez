using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
   public void EmpezarPartida()
   {
        // cargo la escena 1
        SceneManager.LoadScene(1);
   }
    public void TerminarPartida()
    {
      // SOLO FUNCIONA EN EL EJECUTABLE (en unity probando no va a funcionar)
        Application.Quit();
    }
    
}
