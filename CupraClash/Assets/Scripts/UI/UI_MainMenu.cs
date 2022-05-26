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

    public void GoToAlessandro()
    {
        SceneManager.LoadScene("UI_AlessandroChat");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            //Popup Trucada
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            //Canvi Escena trucada
            SceneManager.LoadScene("UI_Calling");
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            //Popup Noti recarga
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            //Canvi Escena Sparks
            SceneManager.LoadScene("UI_SparkExchange");
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            //PopUp Anim Tiempo
           
        }
    }
}
