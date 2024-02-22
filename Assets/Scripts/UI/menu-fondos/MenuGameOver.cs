using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MenuGameOver : MonoBehaviour
{
    [SerializeField] GameObject menuGameOver;
    public movimientoJugador MovimientoJugador;

    private void Start()
    {
      // MovimientoJugador = GameObject.FindGameObjectsWithTag("Jugador").GetComponent<movimientoJugador>();
       MovimientoJugador.MuerteJugador += ActivarMenu;
    }
    private void ActivarMenu(object sender, EventArgs e)
    {
        menuGameOver.SetActive(true);
    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Menu(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliste del juego");
    }
}
