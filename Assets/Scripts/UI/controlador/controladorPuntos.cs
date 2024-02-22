using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorPuntos : MonoBehaviour
{
    //public vistaPuntos[] numberValueViews; 
    public List<vistaPuntos> numberValueViews = new List<vistaPuntos>();

    public void UpdatePuntos(int puntos)
    {
        foreach (var item in numberValueViews)
        {
            int currentNumber = puntos % 10;
            puntos /= 10;

            item.SetNumber(currentNumber);
        }
    }
}
