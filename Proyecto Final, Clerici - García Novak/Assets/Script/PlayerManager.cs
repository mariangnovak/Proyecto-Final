using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int health = 1;
    public int damageTaken = 1;
    public float immunity = 0f;
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
        if (immunity > 0)
        {
            immunity -= Time.deltaTime;
        }
        if(health <= 0 )
        {
            Destroy(this.gameObject);
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
    
        if (collision.gameObject.CompareTag("Enemy") && immunity<=0)
        {
            Damage(damageTaken);
            immunity = 1f;
        }
    }
}
