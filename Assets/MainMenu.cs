using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        Application.Quit();
        Debug.Log("I guit n");
    }

    public void Startbutton()
    {
        SceneManager.LoadScene(1);
    }
}
