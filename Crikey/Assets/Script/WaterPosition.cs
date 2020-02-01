using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPosition : MonoBehaviour
{

    public float StartPositionX;
    public float EndPositionX;
    public float incrementer;



    private void Update()
    {
        if (CrikeyManager.Instance.CurrentActiveHoles > -1)
        {
            float inc = (incrementer * (CrikeyManager.Instance.CurrentActiveHoles * 1))/60;
            transform.position += new Vector3(0, inc, 0);
            if (transform.position.y > EndPositionX)
            {
                CrikeyManager.Instance.PlayerAlive =  false;
            }
        }
    }

}
