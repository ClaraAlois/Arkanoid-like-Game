using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pearls : MonoBehaviour
{
    bool destory;
    private AudioSource good_job;
    Vector3 scale;

    void Start()
    {
        good_job = GameObject.Find("Pearls").GetComponent<AudioSource>();
        destory = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (destory)
        {
            good_job.Play();
            scale = GameObject.Find("paddle").transform.localScale;
            GameObject.Find("paddle").transform.localScale = scale + new Vector3(1, 0, 0);
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        destory = true;
    }
}
