using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goals : MonoBehaviour
{
    public GameObject Personaje;
    
    void OnTriggerEnter2D(){
        principalScript.Score += 10;
        Destroy(this.gameObject, 0f);
    }

}
