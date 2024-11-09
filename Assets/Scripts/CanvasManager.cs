using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] TMP_Text Texto_Muerte;
    private void Update()
    {
        Texto_Muerte.text = "Has muerto";
    }
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
    public void Reintentar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("RollingBall");
    }

}
