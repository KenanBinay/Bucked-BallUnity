using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBallExit : MonoBehaviour
{
    public Animator ResAnim;
    void Start()
    {
        ResAnim.enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("BallExit");
            ResAnim.enabled = true;
        }
        else { return; }
    }
}
