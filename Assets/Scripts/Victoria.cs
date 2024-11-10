using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    [SerializeField] TMP_Text Texto_Victoria;
    private void Update()
    {
        Texto_Victoria.text = "¡ENHORABUENA, HAS GANADO!";
    }
    public void Reintentar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("RollingBall");
    }

}
