using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvasPausa;
    public static int nivelJuego = 0;
    public Bola bola;

    [SerializeField] int puntosObjetivo = 50;
    void Start()
    { 
        canvasPausa.SetActive(false);
    }
    void Update()
        
    {
        if (bola != null && bola.puntosJugador >= puntosObjetivo)
        {
            SceneManager.LoadScene(3); 
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvasPausa.activeSelf)
            {
                canvasPausa.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                canvasPausa.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
    public void Continuar()
    {
        canvasPausa.SetActive(false);
        Time.timeScale = 1;
    }
    public void Reiniciar()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Titulo()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }
    public void Salir()
    {
        print("cerrando...");
        Application.Quit();
    }
    
}   
