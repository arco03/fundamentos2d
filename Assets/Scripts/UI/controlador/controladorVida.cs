using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controladorVida : MonoBehaviour
{
    public List<vistaVida> hearthViews = new List<vistaVida>();

    public void UpdateLife(int amount)
    {

        foreach (var hearth in hearthViews)
        {
            hearth.UpdateHeart(0);
        }

        int amountHearth = (int)amount / 2;

        for (int i = 0; i < amountHearth; i++)
        {
            hearthViews[i].UpdateHeart(2);
        }

        int currentHearth = (int)amount % 2;
        hearthViews[amountHearth].UpdateHeart(currentHearth);

    }
}
