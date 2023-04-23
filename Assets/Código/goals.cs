using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goals : MonoBehaviour
{
    public GameObject Personaje;
    public GameObject gestorSonido;
    
    void OnTriggerEnter2D(){
        principalScript.Score += 10;
        Destroy(this.gameObject, 0f);
        gestorSonido.GetComponent<audioManager>().sonidoPuntos();
    }

}
