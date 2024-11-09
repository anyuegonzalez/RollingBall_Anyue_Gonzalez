using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Intrucciones : MonoBehaviour
{
    [SerializeField] TMP_Text Texto_Instrucciones;  
   
    void Start()
    {
        Texto_Instrucciones.text = "Deberás recolectar quinientos puntos para finalizar el juego con los recogibles dispersos por el escenario. Te puedes mover con las flechas del teclado o con las letras WASD. Saltarás con el espacio y podrás acceder a un menú de juego pulsando la tecla ESC. Asimismo, podrás obtener ciertas habilidades bebiendo las pociones dispuestas en las plataformas. Podrás investigar en la casa de madera. Los puntos están dispersos en los coleccionables en forma de caja de madera. Ojo con las trampas ocultas.";
    }
    public void EmpezarPartida()
    {
        SceneManager.LoadScene(1);
    }
}
