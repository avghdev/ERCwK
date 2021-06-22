using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public float horMultiplier = 2;
    public Rigidbody rb;
    
    float horInput;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void FixedUpdate() {
        Vector3 moveForward = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horMove = transform.right * speed * Time.fixedDeltaTime * horInput;
        rb.MovePosition(rb.position + moveForward + horMove);
    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxis("Horizontal");
    }
}
