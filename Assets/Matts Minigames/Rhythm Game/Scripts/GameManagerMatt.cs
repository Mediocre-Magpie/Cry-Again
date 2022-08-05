using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerMatt : MonoBehaviour
{

    public AudioSource theMusic;

    public bool startPlaying;

    //public ArrowScroller theAS;

    public static GameManagerMatt instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;    
    }

    // Update is called once per frame
    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
               // theAS.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit the Note");
    }

    public void NoteMissed()
    {
        Debug.Log("Missed the Note");
    }
}
