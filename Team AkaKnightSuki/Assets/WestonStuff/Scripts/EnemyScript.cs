using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    //Sets the speed of the enemy.
    public float speed;
    //Sets target to follow
    public Transform target;
    //Sets how close to player in order to follow.
    public float chaseRange;

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
        //Chasing player A.I. (Not working currently)
        //float distanceToTarget = Vector3.Distance(transform.position, target.position); 
       // if(distanceToTarget < chaseRange)
        {
           // Vector3 targetDir = target.position - transform.position;
           // float angle = Mathf.Atan2 (targetDir.y, targetDir.x)* Mathf.Rad2Deg - 90f;
           // Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
           // transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);

           // transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
	}
}
