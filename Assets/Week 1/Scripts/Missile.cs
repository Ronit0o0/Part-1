using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Missile : MonoBehaviour
{ float speed = 5f;
    Vector2 direction = new Vector2(10, 0);
    Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(1 * speed * Time.deltaTime, 0, 0); 
    }
    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + direction * Time.deltaTime);
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("missile hit something");
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("missile triggered something");
    }
}

