using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator animator;
    [SerializeField] GameObject lights;


    private void Start()
    {

        animator = GetComponent<Animator>();
    }
    public void Bottlewin()
    {

        lights.SetActive(true);
        animator.SetTrigger("Open");

    }
}
