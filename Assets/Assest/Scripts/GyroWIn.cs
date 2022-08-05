using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroWIn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Animator animator;
    

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void gyroWin()
    {
        animator.SetTrigger("Open");
    }
}
