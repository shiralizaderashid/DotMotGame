using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCircleCode : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject smallCircle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            CreateSmallCircle();
        }
    }

    void CreateSmallCircle()
    {
        Instantiate(smallCircle, transform.position, transform.rotation);
    }
}
