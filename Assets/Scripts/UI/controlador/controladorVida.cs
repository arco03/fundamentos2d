using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorVida : MonoBehaviour
{
    public static controladorVida Instance {  get; private set; }

    private int vidas = 3;
    public vistaVida vistaVida;

    public void PerderVida()
    {
        vidas -= 1;
        vistaVida.DesactivarVida(vidas);
    }
}
