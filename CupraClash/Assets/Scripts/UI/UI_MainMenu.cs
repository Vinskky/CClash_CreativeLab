using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    public GameObject test;
    bool testFlag = false;
    public void SwitchToSparksMenu()
    {
        //2 == sparks menu
        SceneManager.LoadScene(2);
    }

    public void SwitchToMapMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void SwitchToTribeMenu()
    {
        SceneManager.LoadScene(3);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            testFlag = !testFlag;

            if(testFlag)
            {
                test.GetComponent<Renderer>().material.color = Color.red;

            }
            else
            {
                test.GetComponent<Renderer>().material.color = Color.blue;

            }
        }
    }
}
