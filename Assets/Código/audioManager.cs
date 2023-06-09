using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioManager : MonoBehaviour
{
    public AudioClip bandaSonora;
    public AudioClip clicMenu;
    public AudioClip lanzaBola;    
    public AudioClip sonidoMuerte;
    public AudioClip sonidoGoal;
    public AudioClip sonidoBola;
    private AudioSource hiloMusical;
    private Scene escenaActual;
    public static GameObject scriptDuplicado;

    void Start()
    {
        hiloMusical = GetComponent<AudioSource>();
        hiloMusical.clip = bandaSonora;
        hiloMusical.loop = true;
        hiloMusical.Play();
    }

    // Update is called once per frame
    void Update()
    {
        escenaActual = SceneManager.GetActiveScene();
        if(escenaActual.name == "start"){
            hiloMusical.pitch = 1f;
        } else if(escenaActual.name == "nivel1"){
            hiloMusical.pitch = 1.2f;
        }
    }

    public void clicBoton(){
        hiloMusical.PlayOneShot(clicMenu, 1f);
    }

    public void sonidoDead(){
        hiloMusical.PlayOneShot(sonidoMuerte, 1f);
    }

     public void sonidoPuntos(){
        hiloMusical.PlayOneShot(sonidoGoal, 1f);
    }
}
