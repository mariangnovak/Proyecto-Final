using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 20f;
    //[SerializeField] GameObject enemy;
    public Spawner spawner;

    void Start()
    {
        spawner = GetComponent<Spawner>();

    }

    void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        //else if (collision.gameObject.CompareTag("Walls"))
        //{
        //    Destroy(this.gameObject);
        //}
    }
}
