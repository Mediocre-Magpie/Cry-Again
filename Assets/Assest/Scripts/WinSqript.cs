using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSqript : MonoBehaviour
{
    
    [SerializeField] GameObject WinTrigger;

    

    public int id;
    private void Awake()
    {
        
    }


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            

            

            GameEvents.current.WinCondition(id);
        }
    }
}
