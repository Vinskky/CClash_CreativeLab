using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateKombi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Display.displays.Length; i++)
        {
            
            if(i > 1)
            {
                Display.displays[i].Activate(1250, 467, 60);
            }
            else
            {
                Display.displays[i].Activate();
            }
        }
    }

}
