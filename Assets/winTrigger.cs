using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winTrigger : MonoBehaviour
{
    public GyroWIn win;
   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            win.gyroWin();

            Debug.Log("WIN");
        }
    }
}
