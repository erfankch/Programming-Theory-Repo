using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beetle : MonoBehaviour
{
    private Rigidbody beetleRb;

    public float speed;
    private float zBoundTop = 3.0f;
    private float zBoundBottom = -7.0f;

    // Start is called before the first frame update
    void Start()
    {
        beetleRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BeetleMoveInput();
        ConstrainBeetlePosition();
    }

    void BeetleMoveInput()
    {
        speed = 15;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        beetleRb.AddForce(Vector3.forward * speed * verticalInput);
        beetleRb.AddForce(Vector3.right * speed * horizontalInput);
       
    }

    void ConstrainBeetlePosition()
    {
        if (transform.position.z < zBoundBottom)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundBottom);
        }
        if (transform.position.z > zBoundTop)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBoundTop);
        }
    }
}
