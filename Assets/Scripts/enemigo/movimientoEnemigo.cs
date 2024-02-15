using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEnemigo : MonoBehaviour
{
    public float velocidad;
 
    void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "colision")
        {
            velocidad *= -1;
        }
    }
}
