using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{

    public static float Speed = 2f;
    public bool ActivaSalto = true;
    public float Salto = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GETAXIS
        float H = Input.GetAxis("Horizontal")*Speed;
        H *= Time.deltaTime;
        transform.Translate(H,0,0);

        // INPUTS CONTROL NO DEFINIDOS
        if(Input.GetKey(KeyCode.Space) && ActivaSalto == true ){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,Salto),ForceMode2D.Impulse);
            ActivaSalto = false;
        }

        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)){
            transform.localScale = new Vector3(1,1,1);
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)){
            transform.localScale = new Vector3(-1,1,1);
        }

    }

    void OnCollisionEnter2D(){
        ActivaSalto = true;
    }
}
