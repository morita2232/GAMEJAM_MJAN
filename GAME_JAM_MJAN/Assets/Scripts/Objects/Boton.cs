using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour
{

    public GameObject pared;
    public GameObject paredDos;
    public SpriteRenderer sr;    
    public Sprite newsr;    

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bola")
        {
            Destroy(pared);           
            Destroy(paredDos);
            sr.sprite = newsr;
        }
    }

}
