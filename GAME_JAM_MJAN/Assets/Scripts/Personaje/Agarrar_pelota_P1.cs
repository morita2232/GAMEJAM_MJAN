using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agarrar_pelota_P1: MonoBehaviour
{
    public List <GameObject> pelotaMia;
    public GameObject pelota;
    public int fuerza;


    // Start is called before the first frame update
    void Start()
    {
        fuerza = 20;
    }

    // Update is called once per frame
    void Update()
    {

        if (pelotaMia.Count > 0 && Input.GetKeyDown(KeyCode.D))
        {
            GameObject newPelota = Instantiate(pelota, transform.position, Quaternion.identity);

            pelotaMia.RemoveAt(0);

            Rigidbody2D rb = newPelota.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                rb.AddForce(transform.right * fuerza, ForceMode2D.Impulse);
            }
        }

        if (pelotaMia.Count > 0 && Input.GetKeyDown(KeyCode.W))
        {

            GameObject newPelota = Instantiate(pelota, transform.position, Quaternion.identity);

            pelotaMia.RemoveAt(0);
            
            Rigidbody2D rb = newPelota.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                rb.AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);

            }
        }



    }



}
