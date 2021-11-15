using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform PlayerPos;
    public float speed;
    public float followThresh;
    public bool canMove = true;

    void Update()
    {
        //indicate if it is being looked at by player
        Vector3 moveToward = new Vector3(PlayerPos.position.x, -16.5f, PlayerPos.position.z);

        if (canMove)
        {
            if (Vector3.Distance(this.transform.position, PlayerPos.position) <= followThresh)
            {
                transform.position = Vector3.MoveTowards(this.transform.position, moveToward, speed * Time.deltaTime);
            }
        }
    }
}
