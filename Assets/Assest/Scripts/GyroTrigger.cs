using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GyroTrigger : MonoBehaviour
{
    [SerializeField] GameObject interactText;
    [SerializeField] GameObject puzzle;

    public static bool inGyroTrigger;

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

            inGyroTrigger = true;

            GameEvents.current.PuzzleTriggerEnter(id);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        puzzle.GetComponent<GyrpMovement>().enabled = false;

        interactText.SetActive(false);

        inGyroTrigger = false;

        GameEvents.current.PuzzleTriggerExit(id);
    }

}
