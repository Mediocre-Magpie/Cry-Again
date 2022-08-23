using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch1Win : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject lights;


    private void Start()
    {

        animator = GetComponent<Animator>();
    }
    public void SwitchWin()
    {
        
        lights.SetActive(true);
        animator.SetTrigger("Open");

    }
}
