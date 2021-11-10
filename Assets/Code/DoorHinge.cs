using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHinge : MonoBehaviour
{

    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hand"))
        {
            //rb.isKinematic = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("hand"))
        {
            //rb.isKinematic = true;
        }
    }
}
