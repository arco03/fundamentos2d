using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Saliste del Juego");
    }
}
