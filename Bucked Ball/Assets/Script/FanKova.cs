using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanKova : MonoBehaviour
{
    public GameObject Fan;
    public AudioSource FanSource;
    private float hiz;

    private void Start()
    {
        hiz = -2f;
    }
    private void LateUpdate()
    {
        Fan.transform.Rotate(0, 0, hiz);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            hiz = 0f;
            FanSource.Stop();
        }
    }
}
