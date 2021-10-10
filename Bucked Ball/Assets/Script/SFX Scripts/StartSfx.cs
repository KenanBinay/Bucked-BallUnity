using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSfx : MonoBehaviour
{
    public AudioSource StartSound;

    void Start()
    {
        StartSound.GetComponent<AudioSource>();
        StartSound.Stop();
    }

    public void SoundStart()
    {
        Debug.Log("ButtonSound");
        StartSound.Play();
    }
}
