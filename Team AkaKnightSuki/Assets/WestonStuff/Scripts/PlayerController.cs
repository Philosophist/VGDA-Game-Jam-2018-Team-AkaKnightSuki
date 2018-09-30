using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalSpeed = 5f;
    public int health = 100;
    private bool facingRight;
    private Rigidbody2D rb2d;
    public float torqScaler = 0.025f;
    private bool bothDirectionsInUse = false;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D> ();
        facingRight = true;
	}

    // FixedUpdate
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        //Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        //rb2d.AddForce(movement);

        Vector2 verticalDrift = new Vector2(transform.up.x,transform.up.y);
        Vector2 downThrust = new Vector2(-transform.up.x, -transform.up.y);
        rb2d.AddTorque (moveHorizontal * torqScaler);
        Flip(moveHorizontal);

        
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
           rb2d.AddForce(verticalDrift);
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddForce(verticalDrift);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb2d.AddForce(downThrust*2);
        }
    }

    // Update is called once per frame
    void Update ()
    {
        // float horizontalInput = Input.GetAxisRaw("Horizontal");
        // transform.position = transform.position + new Vector3(horizontalInput * horizontalSpeed * Time.deltaTime, 0, 0);

        
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
