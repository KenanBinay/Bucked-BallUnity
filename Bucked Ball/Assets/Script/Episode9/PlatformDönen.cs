using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDönen : MonoBehaviour
{
    public Transform Object;
    void Start()
    {
        
    }

    
    void Update()
    {
        Object.Rotate(Vector3.forward * Time.deltaTime * 115);
       
    }
}
