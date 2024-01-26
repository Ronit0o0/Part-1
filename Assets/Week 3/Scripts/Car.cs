using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float steeringSpeed = 30;
    public float forwardSpeed = 300;
    public float maxSpeed = 300;
    float steering;
    float acceleration;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        steering = Input.GetAxis("Horizontal");
        acceleration = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Vector2 force = transform.up * acceleration * forwardSpeed * Time.deltaTime;
        rigidBody.AddTorque(steering * -steeringSpeed * Time.deltaTime);
        rigidBody.AddForce(force);
        if (rigidBody.velocity.magnitude < maxSpeed)
        {
            rigidBody.AddForce(force);
        }
    }
}
