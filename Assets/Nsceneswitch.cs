using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nsceneswitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
