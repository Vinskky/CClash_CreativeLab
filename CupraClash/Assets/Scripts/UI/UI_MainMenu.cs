using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    public GameObject recibirRecompensa;
    public GameObject panelMisioncumplida;
    public GameObject panelMision;


    public void OpenPopupRecompensa()
    {
        recibirRecompensa.SetActive(true);
    }
    public void ClosePopupRecompensa()
    {
        recibirRecompensa.SetActive(false);
        panelMisioncumplida.SetActive(true);
        panelMision.SetActive(false);


    }
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

    public void GoToGeneralChat()
    {
        SceneManager.LoadScene("UI_ChatGeneral");
    }

    public void GoToTribuProfile()
    {
        SceneManager.LoadScene("UI_TribuProfile");
    }

    private void Update()
    {
         if (Input.GetKeyDown(KeyCode.Q))
        {
            //SceneManager.LoadScene("UI_Calling");
            //Q para noti Trucada, W para noti de mision, E1 noti bateria baja, E2 noti cargando, E3 noti recuperar zona
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            //Canvi Escena trucada
           // SceneManager.LoadScene("UI_Calling");
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
