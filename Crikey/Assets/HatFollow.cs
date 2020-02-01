using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatFollow : MonoBehaviour
{
    public Transform Cam;
   public Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {
        this.transform.position = Cam.transform.position + offset;

        this.transform.rotation = Cam.transform.rotation;
    }
}
