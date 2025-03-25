/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject[] objetos;
    SpriteRenderer srBola;
    SpriteRenderer srPlataforma;
    Color newColorBola;
    Color newColorPlataforma;
    // Start is called before the first frame update
    void Start()
    {
        srBola = objetos[0].GetComponent<SpriteRenderer>();
        newColorBola = srBola.color;
        srPlataforma = objetos[1].GetComponent<SpriteRenderer>();
        newColorPlataforma = srPlataforma.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bola" && Input.GetKeyDown(KeyCode.L))
        {
            newColorBola.a = 1f;
            srBola.color = newColorBola;
        }

        else if(collision.gameObject.tag == "Objeto" && Input.GetKeyDown(KeyCode.L))
        {
            newColorPlataforma.a = 1f;
            srPlataforma.color = newColorPlataforma;
        }
    }
}
*/
using System.Collections;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public float fadeSpeed = 2f; // Speed of fade-in effect

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Check for colliding objects and make them visible
            foreach (Collider2D col in Physics2D.OverlapCircleAll(transform.position, 1f)) // Adjust range if needed
            {
                if (col.CompareTag("Bola") || col.CompareTag("Objeto"))
                {
                    StartCoroutine(FadeInObject(col));
                }
            }
        }
    }

    private IEnumerator FadeInObject(Collider2D col)
    {
        SpriteRenderer sr = col.GetComponent<SpriteRenderer>();
        Rigidbody2D rb = col.GetComponent<Rigidbody2D>();

        if (sr == null) yield break;

        float alpha = sr.color.a;
        Color newColor = sr.color;

        while (alpha < 1f)
        {
            alpha += Time.deltaTime * fadeSpeed;
            newColor.a = alpha;
            sr.color = newColor;
            yield return null;
        }

        // If it's a ball, allow movement after it becomes visible
        if (rb != null && col.CompareTag("Bola"))
        {
            rb.isKinematic = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Make sure objects start invisible & stationary if needed
        if (collision.CompareTag("Bola") || collision.CompareTag("Objeto"))
        {
            SpriteRenderer sr = collision.GetComponent<SpriteRenderer>();
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            

            if (sr != null)
            {
                Color newColor = sr.color;
                newColor.a = 0f;
                sr.color = newColor;
            }

            if (rb != null && collision.CompareTag("Bola"))
            {
                rb.isKinematic = true; // Ball stays still until revealed
            }
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Objeto"))
        {
            BoxCollider2D bc = collision.GetComponent<BoxCollider2D>();

            if (bc != null && collision.CompareTag("Objeto"))
            {
                bc.isTrigger = false;
            }
        }
    }
}






