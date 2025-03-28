using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_plataforma : MonoBehaviour
{
    public float speed;
    public int startingPoint;
    public Transform[] points;

    public bool button;

    private int i;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startingPoint].position;
        button = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (button == true)
        {
            if (Vector2.Distance(transform.position, points[i].position) < 0.02f)
            {
                i++;
                if (i == points.Length)
                {
                    i = 0;
                }
            }

            transform.position = Vector2.MoveTowards(transform.position, points[i].position, speed * Time.deltaTime);
        }
    }
}
