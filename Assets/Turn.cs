using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ADBannerView = UnityEngine.iOS.ADBannerView;

public class Turn : MonoBehaviour
{


    public float speed;

    void Update()
    {
        transform.Rotate(0,0,speed*Time.fixedDeltaTime);
    }
}
