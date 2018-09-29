using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalSpeed = 5f;
    public int health = 100;
    private bool facingRight;
    private Rigidbody2D rb2d;

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
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement);
        Flip(moveHorizontal);
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
