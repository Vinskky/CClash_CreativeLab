using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapMenu : MonoBehaviour
{
    [SerializeField]private GameObject Ui2;
    [SerializeField] private GameObject mainUi;
    [SerializeField] private GameObject kombiYellow;
    [SerializeField] private GameObject kombiRed;
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
                kombiRed.SetActive(true);
                kombiYellow.SetActive(false);
            }
            else
            {
                Ui2.SetActive(false);
                mainUi.SetActive(true);
                kombiRed.SetActive(false);
                kombiYellow.SetActive(true);
            }
        }
    }
}
