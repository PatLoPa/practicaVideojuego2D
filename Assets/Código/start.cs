using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
    public GameObject CanvasStart;
    public GameObject CanvasControles;

    // Start is called before the first frame update
    void Start()
    {
        CanvasStart.SetActive(true);
        CanvasControles.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
    }

    public void EntrarJuego(){
        SceneManager.LoadScene("nivel1");
    }

    public void MostrarControles(){
        CanvasControles.SetActive(true);
        CanvasStart.SetActive(false);
    }

    public void IraStart(){
         CanvasControles.SetActive(false);
        CanvasStart.SetActive(true);
    }
}
