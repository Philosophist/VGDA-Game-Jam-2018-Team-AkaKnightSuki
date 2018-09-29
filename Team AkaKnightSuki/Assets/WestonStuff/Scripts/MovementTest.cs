using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTest : MonoBehaviour {
    public float horizontalSpeed = 5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.position = transform.position + new Vector3(horizontalInput * horizontalSpeed * Time.deltaTime, 0, 0);
    }
}
