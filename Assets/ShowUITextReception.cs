using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUITextReception : MonoBehaviour
{ 

    public GameObject uiObject;
    public float timer = 5f;

    
    void Start()
    {
        uiObject.SetActive(false);
    }

    
    void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(timer);
        Destroy(uiObject);
        Destroy(gameObject);
    }
}
