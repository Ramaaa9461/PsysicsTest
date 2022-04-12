using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody Rg;

    [SerializeField] float horizontalSpeed;
    [SerializeField] float verticalSpeed;
    [SerializeField] float jumpForce;

    float h;
    float v;
    private void Awake()
    {
        Rg = gameObject.GetComponent<Rigidbody>();
    }

    void Start()
    {

    }
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (isGrounded())
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Rg.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            }
        }

    }
    private void FixedUpdate()
    {

        Rg.AddForce(h * horizontalSpeed, 0, v * verticalSpeed);

    }

    bool isGrounded()
    {
        return (Physics.Raycast(transform.position, Vector3.down, 1f));
    }
}
