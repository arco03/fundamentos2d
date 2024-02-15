using UnityEngine;

public class movimientoJugador : MonoBehaviour
{
    public float speed;
    public int x;
    public int y;
    private bool canMove;
    public GameObject balaJugador;
    public GameObject posicionBala;
    public string Horizontal, disparo;

    private void Awake()
    {
        canMove = true;
    }
    private void Update()
    {
        if(Input.GetKeyDown(disparo))
        {
            GameObject bala = (GameObject)Instantiate(balaJugador);
            bala.transform.position = posicionBala.transform.position;

        }
        int moveX = (int)Input.GetAxisRaw(Horizontal);
        if (moveX != 0 && canMove)
        {
            x += moveX;
            canMove = false;
        }

        Vector2 currentPosition = new Vector2(
            transform.position.x,
            transform.position.y
            );

        if (currentPosition == CalcularDireccion(x, y))
        {
            canMove = true;
        }

    }

    private void FixedUpdate()
    {
        Vector2 finalPosition = CalcularDireccion(x, y);
        transform.position = Vector2.MoveTowards(transform.position, finalPosition, speed);
    }

    Vector2 CalcularDireccion(int x, int y)
    {
        return new Vector2(x + 0.5f, y + 0f);
    }
}
