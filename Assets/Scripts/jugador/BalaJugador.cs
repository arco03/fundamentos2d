using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaJugador : MonoBehaviour
{
    public float velocidadBala;

    void Update()
    {
        Vector2 position = transform.position;
        position = new Vector2 (position.x, position.y + velocidadBala * Time.deltaTime);
        transform.position = position;
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
        if(transform.position.y > max.y)
        {
            Destroy(gameObject);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
