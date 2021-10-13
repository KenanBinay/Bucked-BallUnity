using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdButton : MonoBehaviour
{
    string AdID = "4003837";
    string VideoID = "video";
    void Start()
    {
        Advertisement.Initialize(AdID, false);
    }

   public void ShowAd()
    {
        Advertisement.Show(VideoID);
    }
}
