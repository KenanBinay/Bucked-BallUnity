using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanAudio : MonoBehaviour
{

    public GameObject LevelEnd;
    public AudioSource FanSource;
    private void Start()
    {
        FanSource.GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (LevelEnd.gameObject == true)
        {
            StartCoroutine(FanStop());
        }
    }

    public IEnumerator FanStop()
    {
        yield return new WaitForSeconds(0.30f);
        FanSource.Stop();
    }

}
