using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
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
}
