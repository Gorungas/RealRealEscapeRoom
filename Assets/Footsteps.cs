using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] clips = new AudioClip[3];
    public PlayerMove mover;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(walkSounds());
        mover = GetComponent<PlayerMove>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator walkSounds()
    {
        while(true)
        {
            if (mover.currentSpeed > 1)
            {
                source.PlayOneShot(clips[Random.Range(0, 3)]);
            }
            yield return new WaitForSeconds(.2f);

        }

    }
}
