using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{

    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action<int> onPuzzleTriggerEnter;
    public void PuzzleTriggerEnter(int id)
    {
        if (onPuzzleTriggerEnter != null)
        {
            onPuzzleTriggerEnter(id);
        }
    }

    public event Action<int> onPuzzleTriggerExit;
    public void PuzzleTriggerExit(int id)
    {
        if (onPuzzleTriggerExit != null)
        {
            onPuzzleTriggerExit(id);
        }
    }

   
}
