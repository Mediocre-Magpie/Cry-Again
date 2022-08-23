using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleWin : MonoBehaviour
{
    // Start is called before the first frame update
    public doorOpen win;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            win.Bottlewin();

            Debug.Log("WIN");
        }
    }
}
