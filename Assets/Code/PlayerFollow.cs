using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform PlayerPos;
    public float speed;
    public float followThresh;
    public bool canMove = false;

    void Update()
    {
        //indicate if it is being looked at by player

        if (canMove)
        {
            if (Vector3.Distance(this.transform.position, PlayerPos.position) <= followThresh)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, PlayerPos.position, speed * Time.deltaTime);
                transform.LookAt(PlayerPos.position);
            }
        }
    }
}
