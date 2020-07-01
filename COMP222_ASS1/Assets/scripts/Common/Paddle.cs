using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody rb;
    Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = new Vector3(25, 0, 0);

    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.A)&& transform.position.x >= -7.5f)
        {
                rb.MovePosition(transform.position - direction * Time.fixedDeltaTime);
        }
    
        if (Input.GetKey(KeyCode.D)&& transform.position.x <= 7.5f)
        {
            rb.MovePosition(transform.position + direction * Time.fixedDeltaTime);
        }
        
    }
}
