using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Naudio : MonoBehaviour
{

    public AudioSource backgroundmusic, music;



    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        backgroundmusic.Play();
        music.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
