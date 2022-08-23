using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int health = 50;
    int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Damage(int value)
    {
        health -= value;
    }

    void Heal(int value)
    {
        int aux = health + value;

        if (aux < maxHealth)
            health += value;
        else
            health = maxHealth;
    }
}
