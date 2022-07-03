using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_NotiManager : MonoBehaviour
{
    public Animator animationBateriabaja;
    public Animator animationCargando;
    public Animator animationMisionCumplida;
    public Animator animationNuevoUI;
    public Animator animationLlamada;
    public Animator animationCogerLlamada;

    [SerializeField] private GameObject VideoAtoB;
    [SerializeField] private GameObject VideoLoop;
   


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GoToMisiones()
    {

        SceneManager.LoadScene("UI_Misiones");

    }
    public void GoToSpark()
    {

        SceneManager.LoadScene("UI_SparkExchange");
    }

        public void GoToCalling()
    {
        animationCogerLlamada.SetTrigger("CogerLlamadaTrigger");
        //SceneManager.LoadScene("UI_Calling");
    }

    public void SwapKombiVideo()
    {
        VideoLoop.SetActive(false);
        VideoAtoB.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                //Popup Noti bateria baja
                animationBateriabaja.SetTrigger("NotiTrigger");

            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                //Popup Noti cargando
                animationCargando.SetTrigger("NotiTrigger");

            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                //Popup Noti mision cumplida
                animationNuevoUI.SetTrigger("NotiTrigger");

            }
        }if (Input.GetKeyDown(KeyCode.W))
            animationMisionCumplida.SetTrigger("NotiTrigger");

        if (Input.GetKeyDown(KeyCode.Q))
            animationLlamada.SetTrigger("LlamadaTrigger");

    }
}
