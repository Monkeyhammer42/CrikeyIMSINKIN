using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
public class Corkscript : MonoBehaviour
{
    public Transform cork;
    public Vector3 offset;
    public bool grabbed;
    DistanceGrabbable thisgrabbable;
    void Start()
    {
        thisgrabbable = this.gameObject.GetComponent<DistanceGrabbable>();
    }

    void Update()
    {
        grabbed = thisgrabbable.isGrabbed;
        if (!thisgrabbable.isGrabbed)
        {


            this.transform.position = cork.transform.position + offset;

            this.transform.rotation = cork.transform.rotation;
        }
        else
        {
            
        }
    }
}
