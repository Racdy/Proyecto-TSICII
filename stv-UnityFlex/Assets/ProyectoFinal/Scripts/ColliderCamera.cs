using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision collision)
    {
        // Este método se llama mientras la colisión continúa
    }

    private void OnCollisionExit(Collision collision)
    {
        // Este método se llama cuando la colisión termina
    }
}
