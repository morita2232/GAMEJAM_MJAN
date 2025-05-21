using UnityEngine;
using UnityEngine.Audio;

public class DoorAudioTrigger : MonoBehaviour
{
    public AudioMixer mixer;
    public AudioSource breezeSource;

    private bool firstTriggered = false;
    public bool isFirstDoor = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player") || firstTriggered) return;

        firstTriggered = true;

        if (isFirstDoor)
        {
            mixer.FindSnapshot("Breeze").TransitionTo(1f);
            breezeSource.Play();
        }
        else
        {
            mixer.FindSnapshot("Default").TransitionTo(1f);
            breezeSource.Stop();
        }
    }
}

