using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public GameObject Personaje;
    public GameObject fondoNubes;
    public GameObject fondoArboles;
    public GameObject arbolGrande;

    public static string direccionPersonaje = "parado";

    public float velocidadNubes = 2f;
    public float velocidadArboles = 5f;
    public float velocidadArbolGrande = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        /*

        if(direccionPersonaje == "derecha"){
          velocidadNubes = -0.005f;
          velocidadArboles = -0.01f;
          velocidadArbolGrande = -0.02f;
        }

        if(direccionPersonaje == "izquierda"){
            velocidadNubes = 0.0051f;
            velocidadArboles = 0.01f;
            velocidadArbolGrande = 0.02f;
        }

        if(direccionPersonaje == "parado"){
            velocidadNubes = 0f;
            velocidadArboles = 0f;
            velocidadArbolGrande = 0f;
        }

        float velNubes = velocidadNubes*Time.deltaTime;
        float velArboles = velocidadArboles*Time.deltaTime;
        float velArbolGrande = velocidadArbolGrande*Time.deltaTime;

        */


        fondoNubes.transform.position = new Vector3(
            Personaje.transform.position.x/velocidadNubes,
            Personaje.transform.position.y/velocidadNubes,
            0
        );

        fondoArboles.transform.position = new Vector3(
            Personaje.transform.position.x/velocidadArboles,
            Personaje.transform.position.y/velocidadArboles,
            0
        );

        arbolGrande.transform.position = new Vector3(
            Personaje.transform.position.x/velocidadArbolGrande,
            Personaje.transform.position.y/velocidadArbolGrande,
            0
        );

        //fondoNubes.transform.Translate(Personaje.transform.position.x/10f,0,0);
        //fondoArboles.transform.Translate(velocidadArboles,0,0);
        //arbolGrande.transform.Translate(velocidadArbolGrande,0,0);
    

    }
}
