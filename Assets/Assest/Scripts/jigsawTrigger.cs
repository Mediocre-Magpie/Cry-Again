using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jigsawTrigger : MonoBehaviour
{
    [SerializeField] GameObject interactText;
    [SerializeField] GameObject puzzle;


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

            GameEvents.current.PuzzleTriggerEnter(id);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        puzzle.GetComponent<Puzzletest>().enabled = false;
        interactText.SetActive(false);
        GameEvents.current.PuzzleTriggerExit(id);
    }
}
