using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject pelota_Uno;
    SpriteRenderer sr;
    Color newColor;
    // Start is called before the first frame update
    void Start()
    {
        sr = pelota_Uno.GetComponent<SpriteRenderer>();
        newColor = sr.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bola" && Input.GetKeyDown(KeyCode.L))
        {
            newColor.a = 1f;
            sr.color = newColor;
        }
    }
}
