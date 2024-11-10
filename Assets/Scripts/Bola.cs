using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Threading;
using UnityEngine.SceneManagement;

public class Bola : MonoBehaviour
{
    public int puntosJugador;
    [SerializeField] int vida = 100;
    [SerializeField] Vector3 direccion = new Vector3(0,0,0);
    [SerializeField] float fuerza = 12f, h, v;
    [SerializeField] float fuerzaSalto = 15f, velocidad = 7f, fuerzaMovimiento =  15f;  
    private bool isGrounded = true;
    [SerializeField] float distanciaDeteccionSuelo;
    [SerializeField] LayerMask queEsSuelo;
    [SerializeField] AudioClip sonidoMoneda;
    [SerializeField] AudioManager audioManager; // objeto de clase audioManager
    [SerializeField] TMP_Text Texto_puntuacion;
    [SerializeField] TMP_Text Texto_vidas;
    [SerializeField] private float timerSalto;
    

    private float timerColor;
    private SpriteRenderer sr;



    Rigidbody rb;

    public int Puntos { get => puntosJugador; set => puntosJugador = value; }
    public int PuntosJugador { get => puntosJugador; set => puntosJugador = value; }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

   
    void Update()
    {
         h = Input.GetAxisRaw("Horizontal");
         v = Input.GetAxisRaw("Vertical");
        Texto_puntuacion.text = "Puntuacion; " + puntosJugador;
        Texto_vidas.text = "Vidas; " + vida;
        Salto();
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(h, 0, v).normalized * fuerzaMovimiento, ForceMode.Force);
    }
    bool DetectarSuelo()
    {
        bool resultado = Physics.Raycast(transform.position, new Vector3(0, -1, 0), distanciaDeteccionSuelo, queEsSuelo);
        return resultado;
    }
    void Salto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(DetectarSuelo() == true)
            {
                rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            }     
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Trampa"))
        {
            vida -= 25;
            Destroy(other.gameObject);
            if(vida <= 0)
            {
                Destroy(this.gameObject);
            }
        }
        if (other.gameObject.CompareTag("pocionVerde"))
        {
           
            Destroy(other.gameObject);
            fuerzaSalto *= 2.9f;
            timerSalto = 15f;
        }
        if (other.gameObject.CompareTag("Muerte"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            audioManager.ReproducirSonido(sonidoMoneda);
            Destroy(other.gameObject);
            puntosJugador += 20;
        }
        if (other.gameObject.CompareTag("ColeccionableBoss"))
        {
            audioManager.ReproducirSonido(sonidoMoneda);
            Destroy(other.gameObject);
            puntosJugador += 500;
        }
    }
}
