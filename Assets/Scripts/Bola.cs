using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
   
    Rigidbody rb;
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
        if(other.gameObject.CompareTag("Coleccionable"))
        {
            //audioManager.ReproducirSonido(sonidoMoneda);
            Destroy(other.gameObject);
            puntos += 50;
        }
        if(other.gameObject.CompareTag("Muro"))
        {
            puntos += 5;
        }
        if(other.gameObject.CompareTag("Trampa"))
        {
            vida -= 10;
            if(vida <= 0)
            {
                Destroy(this.gameObject);
            }
        }
        
    }
}
