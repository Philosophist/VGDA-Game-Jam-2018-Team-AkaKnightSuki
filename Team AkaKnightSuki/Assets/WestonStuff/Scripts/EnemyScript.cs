using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour

{ private Animator animator;                          //Variable of type Animator to store a reference to the enemy's Animator component.
        private Transform target;                           //Transform to attempt to move toward each turn.
        private bool skipMove;                              //Boolean to determine whether or not enemy should skip a turn or move this turn.
    public AudioClip MusicClip;
    public AudioSource MusicSource;
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
        MusicSource.Play();
        Destroy(gameObject);

    }

	// Use this for initialization
	void Start ()
    {
        MusicSource.clip = MusicClip;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
