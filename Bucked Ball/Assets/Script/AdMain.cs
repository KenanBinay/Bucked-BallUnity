using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class AdMain : MonoBehaviour
{
    string AdID = "4003837";
    string VideoID = "video";
    void Start()
    {
        Advertisement.Initialize(AdID, false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Advertisement.Show(VideoID);
        }
    }
}
