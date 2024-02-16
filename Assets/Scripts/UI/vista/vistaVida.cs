using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vistaVida : MonoBehaviour
{
    public GameObject[] vidas;

    public void DesactivarVida(int i)
    {
        vidas[i].SetActive(false);
    }

}
