using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanMovement : MonoBehaviour
{
    public GameObject fan;
    public Rigidbody2D top;
    
    [Range(0.0f, 10.0f)]
    public float hýz;
    void Start()
    {
        
    }

    void Update()
    {
        if (Bucked11To12.x12 != 1)
        {
            fan.transform.Rotate(0, 0, -2);
        }
        
    }
    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        top.AddForce(Vector2.right);
        Debug.Log("EtkileþimFan");
    }
    */
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("EtkileþimFan");
        top.AddForce(Vector2.right*hýz);       
    }
   
}
