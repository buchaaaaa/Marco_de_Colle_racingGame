using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public float accelaration = 1;
    public float steerling = 1;
    Rigidbody rigid;

    public bool Candrift = false;
   
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

    }

 


    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        rigid.AddForce(transform.forward * verticalInput * 2 * accelaration * Time.deltaTime);
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * steerling * Time.deltaTime);



        if (Candrift == false)
        {
            Vector3 velocity = rigid.velocity;
            velocity = transform.forward * velocity.magnitude;
            rigid.velocity = velocity;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Candrift == false)
            {
                Candrift = true;
            }
            else
            {
                Candrift = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
        }
    }

     
}