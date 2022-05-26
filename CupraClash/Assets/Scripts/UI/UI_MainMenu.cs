using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("UI_MainMenu");
    }
    public void GoToCupraClash()
    {
        SceneManager.LoadScene("UI_CupraClash");
    }

    public void GoToMisiones()
    {
        SceneManager.LoadScene("UI_Misiones");
    }

    public void GoToTribu()
    {
        SceneManager.LoadScene("UI_Tribu");
    }

    public void GoToProfile()
    {
        SceneManager.LoadScene("UI_Profile");
    }

  
}
