using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScaler : MonoBehaviour
{
    public SpriteRenderer rink;

    // Use this for initialization
    void Start()
    {
        Camera.main.orthographicSize = rink.bounds.size.x * Screen.height / Screen.width * 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
