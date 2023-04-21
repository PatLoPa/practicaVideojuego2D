using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class principalScript : MonoBehaviour
{
    public static int Score = 0;
    public static int Vida = 3;
    public static int Enemigos = 10;
    // Start is called before the first frame update

    public GUISkin miSkin;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Vida: " + Vida + " Score: " + Score);
    }

    void OnGUI()
    {
        GUI.skin = miSkin;
        GUI.Label(new Rect(20, 20, 150, 80), "Vida: " + Vida.ToString(), "estiloScore");
        GUI.Label(new Rect(100, 20, 150, 80), "Score: " + Score.ToString(), "estiloScore");
        GUI.Label(new Rect(200, 20, 150, 80), "Enemigos: " + Enemigos.ToString(), "estiloScore");
        GUI.Label(new Rect(400, 20, 150, 80), "Patijuego", "estiloTitulo");
    }
}
