using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolinController : MonoBehaviour
{
    public float bounceForce = 1000;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounceForce, ForceMode2D.Impulse);
        }
    }
}
