using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    void Start()
    {
        MusicSource.clip = MusicClip;
    }
    // Update is called once per frame
    void Update ()
    {
		if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        // shooting logic
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        MusicSource.Play();
    }
}
