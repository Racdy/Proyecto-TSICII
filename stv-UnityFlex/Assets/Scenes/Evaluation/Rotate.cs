using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    Rigidbody rb;
    public float torque = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //float turn = Input.GetAxis("Vertical");
        rb.AddTorque(rb.transform.forward * torque );
    }
}
