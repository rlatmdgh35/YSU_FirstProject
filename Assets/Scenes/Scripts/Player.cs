using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float health = 100.0f;

    void TakeDamage(int value)
    {
        health -= value;

        if (health <= 0)
            Die();
    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10);
            Destroy(collision.gameObject);
        }
        
    }
}
