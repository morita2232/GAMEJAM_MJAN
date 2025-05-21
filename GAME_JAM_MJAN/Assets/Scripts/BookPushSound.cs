using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BookPushSound : MonoBehaviour
{
    public AudioClip pushSound;
    private bool hasPlayed = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasPlayed && (collision.collider.CompareTag("Player") || collision.collider.CompareTag("Bola")))
        {
            hasPlayed = true;
            AudioSource.PlayClipAtPoint(pushSound, transform.position);
        }
    }
}
