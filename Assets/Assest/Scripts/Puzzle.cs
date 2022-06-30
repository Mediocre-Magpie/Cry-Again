using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
    [SerializeField] GameObject interactText;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject puzzle;

    bool interactOn = false;



    private void Awake()
    {
        interactOn = false;
        interactText.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interactOn == true)
        {
            Player.GetComponent<PlayerController>().enabled = false;
            puzzle.GetComponent<GyrpMovement>().enabled = true;
        }
    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag=="Player")
        {
            interactText.SetActive(true);
            interactOn = true;
                     
          
        }
            
         
    }

    void OnTriggerExit(Collider collision)
    {
        interactText.SetActive(false);
    }
     

    
   
        
}
