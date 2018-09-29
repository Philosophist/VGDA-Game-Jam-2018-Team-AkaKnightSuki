using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Sets the hp to 100 and can be changed in inspector.
    public int health = 100;

    // Takes damage and dies if hp is < 0
    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Removes enemy when killed
    void Die()
    {
        Destroy(gameObject);
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
