using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//[RequireComponent(typeof(Animation))]
public class Res12 : MonoBehaviour
{
    /*
    Vector3 localPos;
    bool wasPlaying;
    private Animation animation;
    void Awake()
    {
        localPos = transform.position;
        wasPlaying = false;
    }

    void LateUpdate()
    {
       if (!animation.isPlaying & !wasPlaying)
            return;

        transform.localPosition += localPos;

        wasPlaying = animation.isPlaying;
    }
    */
    public void RestartGame()
    {
        SceneManager.LoadScene(13);
        StartPointKey.say = 0;
    }
}
