using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTextGen : MonoBehaviour
{
    public GameObject[] texts;
    public int textNumber;
    public int textCount = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("SpaceBar"))
        {
            textNumber = Random.Range(0, 6);
            textCount = 0;
            while (textCount < 6)
            {
                texts[textCount].SetActive(false);
                textCount += 1;
            }
            texts[textNumber].SetActive(true);
        }
    }
}
