using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Transform[] puntoMovimiento;
    [SerializeField] private float distanciaMinima;

    private int siguientePaso = 0;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntoMovimiento[siguientePaso].position, velocidadMovimiento * Time.deltaTime);

        if (Vector2.Distance(transform.position, puntoMovimiento[siguientePaso].position) < distanciaMinima)
        {
            siguientePaso++;
            if (siguientePaso >= puntoMovimiento.Length)
            {
                siguientePaso = 0;
            }
            Girar();
        }
    }

    private void Girar()
    {
        if(transform.position.x < puntoMovimiento[siguientePaso].position.x)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

}
