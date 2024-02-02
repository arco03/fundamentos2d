using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class movimientoImagen : MonoBehaviour
{
    public RawImage _img;
    public float _y;
    void Update()
    {
        _img.uvRect = new Rect(_img.uvRect.position + new Vector2(0, _y) * Time.deltaTime, _img.uvRect.size);
    }
}
