using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvasPausa;
    public static int nivelJuego = 0;
    public static GameManager instance;

    [SerializeField] int puntosJugador = 0;
    [SerializeField] int puntosObjetivo = 1000;
    void Start()
    {
        canvasPausa.SetActive(false);
    }
    void Update()
    {
        if (puntosJugador >= puntosObjetivo)
        {
            CerrarJuego();
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
    void CerrarJuego()
    {
        Debug.Log("¡Has alcanzado los puntos objetivo! Cerrando el juego...");
        Application.Quit();
}   }
