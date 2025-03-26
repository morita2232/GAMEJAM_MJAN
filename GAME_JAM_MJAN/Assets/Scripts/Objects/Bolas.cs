using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolas : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameObject bola;
    public Agarrar_pelota_P1 array;
    public Agarrar_pelota arrayP2;


    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
     
        if (transform.position.y < 0)
        {
            rb.gravityScale = -1;
        }
        else
        {
            rb.gravityScale = 1;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Q) && array.pelotaMia.Count <= 0)
        {
            arrayP2.pelotaMia.Add(bola);
            array.pelotaMia.Add(bola);
            Destroy(gameObject);
        }

    }

}
