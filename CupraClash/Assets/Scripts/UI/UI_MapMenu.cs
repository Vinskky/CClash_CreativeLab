using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class UI_MapMenu : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject objVideo;
    public GameObject objMap;
    public GameObject objGPS;

    void Awake()
    {
        
    }
    public void ReturnButton()
    {
        SceneManager.LoadScene(0);
    }

    public void SwitchToVideo()
    {
        
        video = GetComponent<VideoPlayer>();

        objGPS.SetActive(false);
        objVideo.SetActive(true);
        objMap.SetActive(true);
        //video.GetComponent<Canvas>().gameObject.SetActive(true);
        //video.Play();

    }

    public void SwitchToGPS()
    {
        objGPS.SetActive(true);
        objVideo.SetActive(false);
        objMap.SetActive(false);
    }
}
