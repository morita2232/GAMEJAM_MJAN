using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    /*
    public AudioSource src;
    public AudioClip sound;
    private void Start()
    {
   
    src.clip = sound;
        src.Play();
        
    }
    */
    public void Inicio()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Salir()
    {
        Application.Quit();
    }
    
}
