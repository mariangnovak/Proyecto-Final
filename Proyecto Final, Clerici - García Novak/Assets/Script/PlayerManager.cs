using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int health = 1;
    int maxHealth;

    void Start()
    {
        maxHealth = health;
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage(int value)
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

    private void OnCollisionEnter(Collision collision) { 
    
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        }
    }
}
