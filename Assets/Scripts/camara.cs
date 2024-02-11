using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    //public float speed;
    public Camera MainCamera;
    private void Move(Vector2 direction)
    {

        //transform.Translate(direction * (speed * Time.deltaTime));

        var viewPortPoint = MainCamera.WorldToViewportPoint(transform.position);

        viewPortPoint.x = Mathf.Clamp(viewPortPoint.x, 0.03f, 0.97f);

        transform.position = MainCamera.ViewportToWorldPoint(viewPortPoint);

    }
}
