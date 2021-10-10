using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public AudioSource ButtonSound;

    void Start()
    {
        ButtonSound.GetComponent<AudioSource>();
        ButtonSound.Stop();
    }
  
    public void ButtonSoundStart()
    {
        Debug.Log("ButtonSound");
        ButtonSound.Play();
    }
}
