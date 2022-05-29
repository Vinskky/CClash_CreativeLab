using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMenu : MonoBehaviour
{
    public GameObject Ui2;
    public GameObject mainUi;
    private bool test = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            test = !test;
            if(test)
            {
                Ui2.SetActive(true);
                mainUi.SetActive(false);
            }
            else
            {
                Ui2.SetActive(false);
                mainUi.SetActive(true);
            }
        }
    }
}
