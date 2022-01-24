using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorOtherBelt : MonoBehaviour
{
    void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 velocityProjection = Vector3.Project(rb.velocity, transform.forward);
            rb.velocity = rb.velocity - velocityProjection + transform.forward;
        }
    }
}
