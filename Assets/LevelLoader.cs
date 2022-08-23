using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Load()
    {
        SceneManager.LoadScene(4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
