using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class VolumeOnOff : MonoBehaviour
{
    float volume = 2;
    public GameObject VolumeOn;
    public GameObject VolumeOff;
    public static float VolumeAudio;
    public AudioSource Source;
    void Start()
    {
        VolumeOn.gameObject.SetActive(true);
        VolumeOff.gameObject.SetActive(false);
        
    }
    
    public void VolumeControl()
    {
        if (volume % 2 != 0)
        {
            VolumeAudio = 1f;
            Source.volume = VolumeAudio;
            VolumeOn.gameObject.SetActive(true);
            VolumeOff.gameObject.SetActive(false);

        }

        if (volume % 2 == 0)
        {
            VolumeAudio = 0f;
            Source.volume = VolumeAudio;
            VolumeOn.gameObject.SetActive(false);
            VolumeOff.gameObject.SetActive(true);

        }

        volume++;
    }
}
