using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateKombi : MonoBehaviour
{
    static bool display1 = false;

    // Start is called before the first frame update
    void Awake()
    {
       

        if (Display.displays.Length > 1 && !display1)
        {
            Display.displays[1].Activate();
            display1 = true;
        }
        /*for (int i = 1; i < Display.displays.Length; i++)
        {
            
            if(i > 1)
            {
                Display.displays[i].Activate(1250, 467, 60);
            }
            else
            {
                Display.displays[i].Activate();
            }
        }*/
    }

}
