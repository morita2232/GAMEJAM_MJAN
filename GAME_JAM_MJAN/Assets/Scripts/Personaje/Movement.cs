using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    [Header("Movimiento")]

    private float movimientoHorizontal = 0f;

    [SerializeField] private float velocidadDeMovimiento;
    [Range(0, 0.3f)][SerializeField] private float SuavizadoDeMovimiento;

    private Vector3 velocidad = Vector3.zero;

    private bool mirandoDerecha = true;

    [Header("Salto")]

    [SerializeField] private float fuerzaDeSalto;
    [SerializeField] private LayerMask queEsSuelo;
    [SerializeField] private Transform controladorSuelo;
    [SerializeField] private Vector3 dimensionesCaja;

    private bool saltando = false;
    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movimientoHorizontal = Input.GetAxis("Horizontal") * velocidadDeMovimiento;
    }

    private void FixedUpdate()
    {
        //mover
        Mover(movimientoHorizontal * Time.fixedDeltaTime);
    }

    private void Mover(float moviendo) 
    {
        Vector3 velocidadObjetivo = new Vector2(moviendo, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjetivo, ref velocidad, SuavizadoDeMovimiento);

        if (moviendo > 0 && !mirandoDerecha)
        {
            //girar
            Girar();
        }
        else if (moviendo < 0 && mirandoDerecha)
        {
            //girar
            Girar();
        }
    }

    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

}
