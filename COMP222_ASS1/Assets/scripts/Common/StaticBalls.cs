using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticBalls : MonoBehaviour
{
    bool destory;

    void Start()
    {
        destory = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (destory)
        {
            GameObject.Find("scripts").GetComponent<PointsCounter>().updatePoints();
            GameObject.Find("scripts").GetComponent<AudioControl>().goodControl = true;
            Destroy(gameObject);        
        }
          
    }

    void OnCollisionEnter(Collision collision)
    {
        destory = true;
    }
}
