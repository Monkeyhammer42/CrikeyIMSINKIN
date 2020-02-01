using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
public class Corkscript : MonoBehaviour
{
    public Transform cork;
    public Vector3 offset;
    public bool grabbed;
    private DistanceGrabbable thisgrabbable;
    public bool AttatchedToHat = true; 

    void Start()
    {
        thisgrabbable = this.gameObject.GetComponent<DistanceGrabbable>();
    }

    void Update()
    {
        grabbed = thisgrabbable.isGrabbed;
        if (!thisgrabbable.isGrabbed && AttatchedToHat)
        {
            this.transform.position = cork.transform.position + offset;
            this.transform.rotation = cork.transform.rotation;
        }
        if (thisgrabbable.isGrabbed)
        {
            AttatchedToHat = false;
        }
        if (!thisgrabbable.isGrabbed && !AttatchedToHat)
        {
            CrikeyManager.Instance.CheckDistanceToHole(this.gameObject);
        }
    }

}
