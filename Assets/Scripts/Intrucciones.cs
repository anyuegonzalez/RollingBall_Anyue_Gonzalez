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
        Texto_Instrucciones.text = "Deber�s recolectar quinientos puntos para finalizar el juego con los recogibles dispersos por el escenario. Te puedes mover con las flechas del teclado o con las letras WASD. Saltar�s con el espacio y podr�s acceder a un men� de juego pulsando la tecla ESC. Asimismo, podr�s obtener ciertas habilidades bebiendo las pociones dispuestas en las plataformas. Podr�s investigar en la casa de madera. Los puntos est�n dispersos en los coleccionables en forma de caja de madera. Ojo con las trampas ocultas.";
    }
    public void EmpezarPartida()
    {
        SceneManager.LoadScene(1);
    }
}
