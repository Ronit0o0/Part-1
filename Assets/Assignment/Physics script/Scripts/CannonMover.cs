using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMover : MonoBehaviour
{
    float speed = 2f; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Horizontal"); // delcares keypresses to move left and right
        transform.Translate(keyboardInput * speed * Time.deltaTime, 0, 0);
    }

   
}