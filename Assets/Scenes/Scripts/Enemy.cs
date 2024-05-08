using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 50.0f;
    public float speed = 50.0f;

    public virtual void Move()
    {
        
    }

    void TakeDamage(int value)
    {
        health -= value;

        if (health <= 0)
            Die();
    }   

    public void Die()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(10);
            collision.gameObject.SetActive(false);
        }
    }

    public float GetHealth()
    {
        return health;
    }

    


}
