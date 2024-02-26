using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    public int puntos = 0;
    private bool colision = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        Disparo();

        Debug.Log(puntos);
        puntos++;

    }
     
    public void Disparo()
    {
        Destroy(gameObject);
        colision = true;


    }
}
