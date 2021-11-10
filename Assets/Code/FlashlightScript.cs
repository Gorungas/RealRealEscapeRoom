using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightScript : MonoBehaviour
{
    public LayerMask enemyLayer;
    public PlayerFollow chaseScript;
    private void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 10.0f, enemyLayer)) {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            chaseScript.canMove = false;
        }
        else
        {
            chaseScript.canMove = true;
        }
    }
}
