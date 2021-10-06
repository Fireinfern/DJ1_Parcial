using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;

    private float jumpForce = 400.0f;

    private bool isGrounded = true;

    void Update() {
        Jump();
    }

    void FixedUpdate()
    {
        HorizontalMovement();
    }

    private void Jump() {
        if(isGrounded && Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce);
            isGrounded = false;
        }
    }

    private void HorizontalMovement()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            Vector3 newPosition = transform.position +
                (Vector3.right * Input.GetAxis("Horizontal") *
                this.speed * Time.deltaTime);
            transform.position = newPosition;
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            this.isGrounded = true;
        }
    }
}
