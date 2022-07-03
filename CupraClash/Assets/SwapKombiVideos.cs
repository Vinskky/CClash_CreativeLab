using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapKombiVideos : MonoBehaviour
{
    [SerializeField] private GameObject VideoAtoB;
    [SerializeField] private GameObject VideoLoop;
    [SerializeField] private GameObject VideoNFT;
    private bool test = false;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
            if (VideoAtoB.activeInHierarchy)
            {
                VideoAtoB.SetActive(false);
                VideoLoop.SetActive(true);
            }
            else
            {
                VideoAtoB.SetActive(true);
                VideoLoop.SetActive(false);
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            VideoAtoB.SetActive(false);
            VideoNFT.SetActive(true);
            VideoLoop.SetActive(false);
        }
    }
}
