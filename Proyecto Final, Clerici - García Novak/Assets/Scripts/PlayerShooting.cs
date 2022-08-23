using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float shootDelay = 1f;
    [SerializeField] private float timeToShoot = 0f;
    [SerializeField] private Transform shootPoint;

    private GameObject bulletClone;

    void Start()
    {

    }

    void Update()
    {
        timeToShoot -= Time.deltaTime;
        if (Input.GetMouseButton(0) && timeToShoot <= 0)
        {
            Shoot();
            timeToShoot = shootDelay;
        }
    }

    void Shoot()
    {
        bulletClone = Instantiate(bullet, shootPoint.position, shootPoint.rotation);
        Destroy(bulletClone, 5f);
    }
}
