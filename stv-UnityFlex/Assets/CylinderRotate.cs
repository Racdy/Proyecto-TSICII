using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderRotate : MonoBehaviour
{

    Rigidbody rigidbody_;
    public float ftorque = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody_.AddTorque(ftorque * rigidbody_.transform.forward );
    }
}
