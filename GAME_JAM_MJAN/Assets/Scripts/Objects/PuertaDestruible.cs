using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaDestruible : MonoBehaviour
{

    public GameObject PuertaI;
    public GameObject Bola;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            Destroy(gameObject);
            Destroy(PuertaI);
            Destroy(Bola);
        }
    }
}
