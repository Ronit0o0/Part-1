using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotator : MonoBehaviour
{
    float speed = 10;
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        rigidbody.AddTorque(speed * Time.deltaTime);
    }
}
