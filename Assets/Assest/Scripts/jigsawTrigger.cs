using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jigsawTrigger : MonoBehaviour
{
    [SerializeField] GameObject interactText;
    [SerializeField] GameObject puzzle;

    public static bool inJigsawTrigger;

    public int id;
    private void Awake()
    {
        interactText.SetActive(false);
    }

    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactText.SetActive(true);

            inJigsawTrigger = true;

            GameEvents.current.PuzzleTriggerEnter(id);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        
        interactText.SetActive(false);
        
        inJigsawTrigger = false;
        
        GameEvents.current.PuzzleTriggerExit(id);
    }
}
