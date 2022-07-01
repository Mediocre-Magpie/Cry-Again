using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle : MonoBehaviour
{
    [SerializeField] GameObject stopPuzzle;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject puzzle;

    public int id;

    private void Start()
    {
        GameEvents.current.onPuzzleTriggerEnter += PuzzleTriggerEnter;
        
    }

    private void Awake()
    {
        stopPuzzle.SetActive(false);
    }

    private void Update()
    {
        PuzzleTriggerEnter(id);
       
    }


   


    
     
    void PuzzleTriggerEnter(int id)
    {
        if (id == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player.GetComponent<PlayerController>().enabled = false;
                puzzle.GetComponent<GyrpMovement>().enabled = true;
                stopPuzzle.SetActive(true);
                //Debug.Log("yes");
            }


            if (Input.GetKeyDown(KeyCode.R) && Player.GetComponent<PlayerController>().enabled == false)
            {
                Player.GetComponent<PlayerController>().enabled = true;
                puzzle.GetComponent<GyrpMovement>().enabled = false;
                stopPuzzle.SetActive(false);
            }
        }
        
       if (id == 0)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Player.GetComponent<PlayerController>().enabled = false;
                puzzle.GetComponent<Puzzletest>().enabled = true;
                stopPuzzle.SetActive(true);
                //Debug.Log("yes");
            }

            if (Input.GetKeyDown(KeyCode.R) && Player.GetComponent<PlayerController>().enabled == false)
            {
                Player.GetComponent<PlayerController>().enabled = true;
                puzzle.GetComponent<Puzzletest>().enabled = false;
                stopPuzzle.SetActive(false);
            }
        }  
        
        
    }

   
   
}
