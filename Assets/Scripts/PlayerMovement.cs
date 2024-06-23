using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rgb;
    private float moveSpeed;
    private float jumpSpeed;
    private float gravityScale;
    private float slideSpeed;
    private int laneIndex;
    void Awake()
    {
        rgb = GetComponent<Rigidbody>();
        moveSpeed = 30f;
        jumpSpeed = 100f;
        gravityScale = 50f;
        slideSpeed = 130f;
        laneIndex = 0;
    }

    private void Update()
    {

        rgb.AddForce(Vector3.forward * moveSpeed, ForceMode.Force);
        rgb.AddForce(Physics.gravity * gravityScale * Time.fixedDeltaTime, ForceMode.Acceleration);

        if (Input.GetButtonDown("Jump") && rgb.velocity.y == 0f)
        {
            rgb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (laneIndex != 1)
            {
                laneIndex++;
                rgb.AddForce(Vector3.right * slideSpeed, ForceMode.Impulse);
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (laneIndex != -1)
            {
                laneIndex--;
                rgb.AddForce(Vector3.left * slideSpeed, ForceMode.Impulse);
            }
        }

    }
}
