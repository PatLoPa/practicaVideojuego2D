using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverbala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (movimiento.direccionBala == true){
            transform.Translate(new Vector2(Time.deltaTime * 7, 0));
        }
        if (movimiento.direccionBala == false){
            transform.Translate(new Vector2(-Time.deltaTime * 7, 0));
        }
    }
}
