using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vistaVida : MonoBehaviour
{
    public Sprite vida1;
    public Sprite vida2;
    public Sprite vida3;

    private Image imageRender;

    private void Awake()
    {
        imageRender = GetComponent<Image>();
    }

    public void UpdateHeart(int lives)
    {
    //   // switch (lives)
    //    {
    //        case 2:
    //            imageRender.sprite = fullHeart;
    //            break;
    //        case 1:
    //            imageRender.sprite = halfHeart;
    //            break;
    //        case 0:
    //            imageRender.sprite = emptyHeart;
    //            break;
    //    }
    }
}
