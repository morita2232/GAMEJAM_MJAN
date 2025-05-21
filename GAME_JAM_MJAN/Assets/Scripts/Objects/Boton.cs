using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Boton : MonoBehaviour
{
    public GameObject pared;
    public GameObject paredDos;
    public SpriteRenderer sr;
    public Sprite newsr;

    [Header("Audio Control")]
    public AudioClip buttonSound;
    public AudioMixer mixer;
    public AudioSource breezeSource;

    private bool triggered = false;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!triggered && (collision.CompareTag("Player") || collision.CompareTag("Bola")))
        {
            triggered = true;

            AudioSource.PlayClipAtPoint(buttonSound, transform.position);

            Destroy(pared);
            Destroy(paredDos);
            sr.sprite = newsr;

            mixer.FindSnapshot("Breeze").TransitionTo(1f);
            breezeSource.Play();
        }
    }
}

