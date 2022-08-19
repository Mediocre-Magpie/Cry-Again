using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOneScript : MonoBehaviour
{
    [SerializeField] GameObject interactText;
    [SerializeField] GameObject SecondSwitch;
    
    public static bool inSwitchOneTrigger;

   
    // Start is called before the first frame update
    private void Awake()
    {
        interactText.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactText.SetActive(true);

            inSwitchOneTrigger = true;

            if (Input.GetKeyDown(KeyCode.E))
            {
                SecondSwitch.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        

        interactText.SetActive(false);

        inSwitchOneTrigger = false;

       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
