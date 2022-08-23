using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DrMorbLevel : MonoBehaviour
{
    public GameObject uiObject;
    bool InTrigger =  false;


    void Start()
    {
        uiObject.SetActive(false);
    }

    public void Update()
    {
        if(InTrigger == true)
        {
            DrMorb();
        }
    }


    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            InTrigger = true;

     

        }
    }

    public void DrMorb()
    {
        //public void MorbidLevel()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("I am working");
                SceneManager.LoadScene(2);
            }
        }
    }
    
}

