using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 50;
    // impactEffect currently unavaliable because of some difficulties.
    // public GameObject impactEffect;

	// Use this for initialization
	void Start ()
    {
        rb.velocity = transform.right * speed;
	}

    // Code for hitting an enemy
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        EnemyScript enemy = hitInfo.GetComponent<EnemyScript>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        // Part of the impactEffect code meaning it changes the sprite as the bullet hits something.
        // Instantiate(impactEffect, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
