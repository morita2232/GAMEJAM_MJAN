using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Llave : MonoBehaviour
{
    public GameObject puerta_Uno;
    public GameObject puerta_Dos;

    [Header("Audio Control")]
    public AudioClip pickupSound;
    public AudioClip doorOpenSound;
    public AudioMixer mixer;
    public AudioSource breezeSource;

    private bool triggered = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggered && collision.CompareTag("Player"))
        {
            triggered = true;

            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            AudioSource.PlayClipAtPoint(doorOpenSound, puerta_Uno.transform.position);

            Destroy(puerta_Uno);
            Destroy(puerta_Dos);
            Destroy(gameObject);

            mixer.FindSnapshot("Default").TransitionTo(1f);
            breezeSource.Stop();
        }
    }
}

