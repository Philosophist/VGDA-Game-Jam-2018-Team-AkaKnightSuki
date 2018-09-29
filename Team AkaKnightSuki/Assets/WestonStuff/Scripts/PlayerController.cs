using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalSpeed = 5f;
    public int health = 100;
    private bool facingRight;
   
    // Use this for initialization
    void Start () {
        facingRight = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.position = transform.position + new Vector3(horizontalInput * horizontalSpeed * Time.deltaTime, 0, 0);

        Flip(horizontalInput);
    }
    //Used for flipping character depending on their movement direction
    private void Flip(float horizontalInput)
    {
        if (horizontalInput > 0 && !facingRight || horizontalInput < 0 && facingRight)
        {
            facingRight = !facingRight;

            transform.Rotate(0f, 180f, 0f);
        }
    }
}
