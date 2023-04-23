using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public string clonBala;

    float SpeedEnemigo = 0.6f;
    float DistanciaPlayer = 4f;
    Vector3 posicionInicial;
    public GameObject player;
    public GameObject gestorSonido;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        posicionInicial = transform.position;
    }

    void Update(){
        Vector3 Objetivo = posicionInicial;
        float distancia = Vector3.Distance(player.transform.position, transform.position);
        if(distancia < DistanciaPlayer){
            Objetivo = player.transform.position;
        }
        float Velocidadfija = SpeedEnemigo * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Objetivo, Velocidadfija);

        Debug.DrawLine(transform.position, Objetivo, Color.green);
    }

    void OnTriggerEnter2D(Collider2D col){
        clonBala = col.gameObject.name;
        Debug.Log("Impactado por: " + col.gameObject.name);
        if(clonBala == "balafuego(Clone)"){
            Destroy(this.gameObject,0.1f);
            gestorSonido.GetComponent<audioManager>().sonidoDead();
        }
        if(clonBala == "personaje"){
            Debug.Log("Impactado por: " + col.gameObject.name);
            principalScript.Vida--;
            principalScript.Enemigos--;
            player.transform.position = new Vector2(0,0);
        }
    }
}
