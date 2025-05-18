using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolinController : MonoBehaviour
{
    public float bounceForce = 1000;
    public AudioClip bounceSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(bounceSound, transform.position);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}
