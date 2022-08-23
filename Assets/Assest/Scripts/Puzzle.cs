using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puzzle : MonoBehaviour
{
    [SerializeField] GameObject stopPuzzle;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject puzzle;
    [SerializeField] GameObject SecondSwitch;
    [SerializeField] GameObject Light;
    [SerializeField] GameObject Jigsaw;

    public int id;

    private void Start()
    {
        GameEvents.current.onPuzzleTriggerEnter += PuzzleTriggerEnter;
        GameEvents.current.winCondition += WinCondition;
    }

    private void Awake()
    {

        stopPuzzle.SetActive(false);
    
    }


    public void Update()
    {

        PuzzleTriggerEnter(id);
    
    }


    void PuzzleTriggerEnter(int id)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ActivatePuzzle(true);
        }

        if (Input.GetKeyDown(KeyCode.R)) //&& Player.GetComponent<PlayerController>().enabled == false
        {
            ActivatePuzzle(false);
        }




        
    }

    public void ActivatePuzzle(bool enabled)
    {
        Player.GetComponent<PlayerController>().enabled = !enabled; 

        if (id == 1 && GyroTrigger.inGyroTrigger == true)
        {
            puzzle.GetComponent<GyrpMovement>().enabled = enabled;
           
        }
        else if (id == 2 && jigsawTrigger.inJigsawTrigger == true)
        {
            SceneManager.LoadScene(3);
        }

        else if (id == 3 && SwitchOneScript.inSwitchOneTrigger == true)
        {
            SecondSwitch.SetActive(true);
        }
        else if (id == 4 && SwitchTrigger.inTwoTrigger == true)
        {
            Jigsaw.SetActive(true);
            Light.SetActive(true);
        }
        stopPuzzle.SetActive(enabled);
    }

    void WinCondition(int id)
    {
        Debug.Log("win");
    }
    

}
