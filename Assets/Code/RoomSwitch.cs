using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSwitch : MonoBehaviour
{


    public GameObject[] rooms;

    public int roomNum = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (roomNum >= rooms.Length)
        {
            roomNum = 0;
        }

        for (int i = 0; i < rooms.Length; i++)
        {
            if (i == roomNum)
            {
                rooms[i].SetActive(true);
            }
            else
            {
                rooms[i].SetActive(false);
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            roomNum++;
        }
    }

}
