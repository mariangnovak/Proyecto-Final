using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemigo;
    public int cantidadMaxima;
    int cantidadSpawneada;
    int cantidadActiva;
    public int maximoSimultaneo;
    public Vector3 offSet = new Vector3(0, 0, -2);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnearEnemigo", 2f,2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //if (cantidadActiva < maximoSimultaneo && cantidadSpawneada <= cantidadMaxima)
        //{
            
        //    cantidadActiva++;
        //    cantidadSpawneada++;
        //}
    }

    void SpawnearEnemigo()
    {
        Instantiate(Enemigo, transform.position + offSet, transform.rotation);
        offSet.z--;
    }

    //public void EnemyDestroyed(int aux)
    //{
    //    cantidadActiva--;
    //}

}
