using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CClashManager : MonoBehaviour
{
    [SerializeField] private GameObject VideoMap1;
    [SerializeField] private GameObject VideoMap2;
    [SerializeField] private GameObject VideoMap3;
    [SerializeField] private GameObject VideoMap4;
    [SerializeField] private GameObject VideoMap5;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            VideoMap1.SetActive(true);
            VideoMap2.SetActive(false);
            VideoMap3.SetActive(false);
            VideoMap4.SetActive(false);
            VideoMap5.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            VideoMap1.SetActive(false);
            VideoMap2.SetActive(true);
            VideoMap3.SetActive(false);
            VideoMap4.SetActive(false);
            VideoMap5.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            VideoMap1.SetActive(false);
            VideoMap2.SetActive(false);
            VideoMap3.SetActive(true);
            VideoMap4.SetActive(false);
            VideoMap5.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            VideoMap1.SetActive(false);
            VideoMap2.SetActive(false);
            VideoMap3.SetActive(false);
            VideoMap4.SetActive(true);
            VideoMap5.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            VideoMap1.SetActive(false);
            VideoMap2.SetActive(false);
            VideoMap3.SetActive(false);
            VideoMap4.SetActive(false);
            VideoMap5.SetActive(true);
        }
    }
}
