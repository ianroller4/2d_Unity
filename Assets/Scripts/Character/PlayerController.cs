using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float crouchSpeed = 2f;
    public float walkSpeed = 5f;
    public float sprintSpeed = 10f;
    float currSpeed;
    bool isCrouching;
    Rigidbody2D rb;

    private void Awake () {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    private void Start() {
        
    }

    // Update is called once per frame
    private void Update() {

    }

    private void FixedUpdate () {
        Crouch();
        Move();
    }

    private void Move () {

        Vector2 moveVec = GetMoveDir();

        MoveSpeed();

        rb.velocity = moveVec * currSpeed;
    }

    private Vector2 GetMoveDir () {

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        return new Vector2(x, y).normalized;

    }

    private void MoveSpeed () {

        if (!isCrouching) {
            if (Input.GetKey(KeyCode.LeftShift)) {
                currSpeed = sprintSpeed;
            } else {
                currSpeed = walkSpeed;
            }
        } else {
            currSpeed = crouchSpeed;
        }

    }

    private void Crouch () {

        if (Input.GetKey(KeyCode.Space)) {
            transform.localScale = new Vector3(1f, 0.5f, 1f);
            isCrouching = true;
        } else {
            transform.localScale = new Vector3(1f, 1f, 1f);
            isCrouching = false;
        }

    }
}
