using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    private AudioSource music;
    private AudioSource good;
    private AudioSource fail;
    private AudioSource levelUp;

    public bool musicControl;
    public bool goodControl;
    public bool failControl;
    public bool levelUpControl;

    void Start()
    {
        music = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        good = GameObject.Find("paddle").GetComponent<AudioSource>();
        fail = GameObject.Find("gameBall").GetComponent<AudioSource>();
        levelUp = GameObject.Find("timer").GetComponent<AudioSource>();

        musicControl = false;
        goodControl = false;
        failControl = false;
        levelUpControl = false;
}

    // Update is called once per frame
    void Update()
    {
        if (musicControl)
        {
            music.Play();
            musicControl = false;
        }
        if (goodControl)
        {
            good.Play();
            goodControl = false;
        }
        if (failControl)
        {
            fail.Play();
            failControl = false;
        }
        if (levelUpControl)
        {
            levelUp.Play();
            levelUpControl = false;
        }
    }
}
