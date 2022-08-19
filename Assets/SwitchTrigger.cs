using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchTrigger : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField] GameObject interactText;
    [SerializeField] GameObject puzzle;

    public static bool inTwoTrigger;

    public int id;

    private void Start()
    {

       
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactText.SetActive(true);

            inTwoTrigger = true;

            GameEvents.current.PuzzleTriggerEnter(id);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        

        interactText.SetActive(false);

        inTwoTrigger = false;

        GameEvents.current.PuzzleTriggerExit(id);
    }
   
}
