using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsOpen : MonoBehaviour
{
    Animator Stairsopen;
    
    // Start is called before the first frame update
    void Start()
    {
        Stairsopen = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Stairsopen.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
