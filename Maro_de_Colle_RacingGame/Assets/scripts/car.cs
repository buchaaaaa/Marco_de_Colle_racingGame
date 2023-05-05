using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float accelaration = 1;
    public float steerling = 1;
    Rigidbody rigid;

    
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        rigid.AddForce(transform.forward * verticalInput * 2* accelaration * Time.deltaTime);
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * steerling* Time.deltaTime);

        Vector3 velocity = rigid.velocity;
        velocity = transform.forward * velocity.magnitude;
        rigid.velocity = velocity;
    }
}
