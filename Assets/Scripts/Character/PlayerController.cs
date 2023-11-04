using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 5f;
    public float sprintSpeed = 10f;

    float speedX;
    float speedY;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() {

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update() {

        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.velocity = new Vector2(speedX, speedY);

    }
}
