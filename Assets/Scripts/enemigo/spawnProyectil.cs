using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProyectil : MonoBehaviour
{
    public GameObject balaEnemigo;
    public float tiempoSpawn;
    public float spawnMax ;
    public float spawnMin ;

    private void Start()
    {
        tiempoSpawn = Random.Range(spawnMin, spawnMax);
    }
    void Update()
    {
        tiempoSpawn -= Time.deltaTime;
        if (tiempoSpawn <= 0)
        {
            Instantiate(balaEnemigo, transform.position, Quaternion.identity);
            tiempoSpawn = Random.Range(spawnMin, spawnMax);
        }
       
        
    }
}
