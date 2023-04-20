using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventos : MonoBehaviour
{
    GameObject miPrefab;


/*
    int miasdmflasdi = 1;
    float flotante = 1.8f;
    string hola = "hola";
    bool hadfklsj = true;
*/

    //bool estado = true;

    // Start is called before the first frame update
    void Start()
    {
        
        miPrefab = GameObject.Find("CubeRojo");

        Debug.Log("Hola mundo");
/*
        for(int i = 0; i <= 10; i++){
            Instantiate(miPrefab, new Vector3(0,i*10f,0), Quaternion.identity);
        }
*/




    }

    // Update is called once per frame
    void Update()
    {




        /*
        if(Input.GetMouseButtonDown(0)){		
            Debug.Log("Se	ha	presionado	el	botón	izquierdo");
        };
        if(Input.GetMouseButtonDown(1))	{
            Debug.Log("Se	ha	presionado	el	botón	derecho");
        }
        if(Input.GetMouseButtonDown(2)){
            Debug.Log("Se	ha	presionado	el	botón	central");
        }
        */

        //Event eventoTecla = Event.current;

        //Debug.Log(Input.GetKeyDown(KeyCode.A));

        /*
                if (Input.GetKeyDown(KeyCode.A) && (estado == true)) {
                    Cursor.visible = false;
                    estado = false;
                    Debug.Log("FALSE");
                }else if (Input.GetKeyDown(KeyCode.A) && (estado == false)) {
                    Cursor.visible = true;
                    estado = true;
                    Debug.Log("TRUE");
                }
        */

        if (Input.GetKeyDown(KeyCode.A)) {
       
            for(int i = 0; i <= 10; i++){
                Instantiate(miPrefab, new Vector3(0,i*10f,0), Quaternion.identity);
            }

        }



    }

    void OnGUI(){

        Event e = Event.current;
        //Debug.Log(e.mousePosition);

    }

        









/*
OnMouseDown.	El	botón	del	ratón	ha	sido	presionado sobre	un	elemento	del	GUI	
(ej. objeto).	
OnMouseUp	Un	botón	del	ratón	ha	sido	liberado de	la	presión	sobre	el		objeto.	
OnMouseEnter El	ratón	entra	en	el	objeto.
OnMouseOver El	ratón	esta	sobre	el	objeto.
OnMouseExit El	ratón	sale	del	objeto.
OnMouseDrag El	ratón	se	arrastra	sobre	el	objeto.
*/

}
