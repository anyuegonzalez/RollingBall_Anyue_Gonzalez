using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bola : MonoBehaviour
{
    [SerializeField] int vida = 100,puntos;
    [SerializeField] Vector3 direccion = new Vector3(0,0,0);
    [SerializeField] float fuerza = 12f, h, v;
    [SerializeField] float fuerzaSalto = 15f, velocidad = 7f, fuerzaMovimiento =  15f;  
    private bool isGrounded = true;
    [SerializeField] float distanciaDeteccionSuelo;
    [SerializeField] LayerMask queEsSuelo;
    [SerializeField] AudioClip sonidoMoneda;
    [SerializeField] AudioManager audioManager; // objeto de clase audioManager
    [SerializeField] TMP_Text Texto_puntuacion;



    Rigidbody rb;

    public int Puntos { get => puntos; set => puntos = value; }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioManager = GetComponent<AudioManager>();
        //sonidoMoneda = GetComponent<AudioClip>();
    }

   
    void Update()
    {
         h = Input.GetAxisRaw("Horizontal");
         v = Input.GetAxisRaw("Vertical");
        Texto_puntuacion.text = "Puntuacion; " + puntos;
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
   /* void ColorTimer()
    {
        if (timerColor > 0)
        {
            timerColor -= Time.deltaTime;
            if (timerColor <= 0)
            {
                sr.color = Color.white;
            }
        }
    }*/
    /*void SaltoTimer()
    {
        if (timerSalto > 0)
        {
            timerSalto -= Time.deltaTime;
            if (timerSalto <= 0)
            {
                fuerzaSalto = 4;
            }
        }
    }*/
    void Sanacion()
    {
        if (vida <= 100)
        {
            vida = +10;
        }
        else if( vida >= 100)
        {
            vida -= 50;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coleccionable"))
        {
            //audioManager.ReproducirSonido(sonidoMoneda);
            Destroy(other.gameObject);
            puntos += 20;
        }
        if (other.gameObject.CompareTag("ColeccionableBoss"))
        {
            //audioManager.ReproducirSonido(sonidoMoneda);
            Destroy(other.gameObject);
            puntos += 500;
        }
        if(other.gameObject.CompareTag("Trampa"))
        {
            vida -= 20;
            if(vida <= 0)
            {
                Destroy(this.gameObject);
            }
        }
        
    }
}
