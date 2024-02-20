using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorVida : MonoBehaviour
{
    public vistaVida vistaVida;

    public void PerderVida(int vidas)
    {
        vistaVida.DesactivarVida(vidas);
    }
}
