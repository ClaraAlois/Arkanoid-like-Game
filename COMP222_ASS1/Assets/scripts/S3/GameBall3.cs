using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBall3 : MonoBehaviour
{
    public bool pause;
    public bool firstVelocity;
    public Rigidbody rb;
    bool set;

    void Start()
    {
        pause = GameObject.Find("scripts").GetComponent<Timer>().pause;
        rb = GetComponent<Rigidbody>();
        firstVelocity = false;
        set = false;
    }

    void Update()
    {
        pause = GameObject.Find("scripts").GetComponent<Timer>().pause;
        if (pause == false)
        {
            if (firstVelocity == false)
            {
                rb.velocity = new Vector3(15, 12, 0);
                firstVelocity = true;
            }
            else
            {
                if (transform.position.y < -8)
                {
                    if (!set)
                    {
                        GameObject.Find("scripts").GetComponent<AudioControl>().failControl = true;
                        set = true;
                    }
                    transform.position = new Vector3(-7, -8, 0);
                    rb.velocity = new Vector3(15, 12, 0);
                }
                set = false;
            }
        }

    }

}
