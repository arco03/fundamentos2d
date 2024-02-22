using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador : MonoBehaviour
{
    public int puntos;
    public void Disparo()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            Disparo();
            puntos += 1;
            Debug.Log(puntos);
    }
}
