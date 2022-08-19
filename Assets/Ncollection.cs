using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ncollection : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Bottle")
        {
            // destroy this object.
            Destroy(collider.gameObject);
        }






    }
}
