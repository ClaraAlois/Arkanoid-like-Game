using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUp2 : MonoBehaviour
{
    public int marks;
    float timer;
    private Text text;
    bool set;

    void Start()
    {
        marks = GameObject.Find("scripts").GetComponent<PointsCounter>().marks;
        text = GameObject.Find("timer").GetComponent<Text>();
        set = false;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        marks = GameObject.Find("scripts").GetComponent<PointsCounter>().marks;
        if (marks == 6)
        {
            timer += Time.deltaTime;
            text.text = "Entering next level...";
            if (!set)
            {
                GameObject.Find("scripts").GetComponent<AudioControl>().levelUpControl = true;
                set = true;
            }
            Destroy(GameObject.Find("gameBall"));

            if (timer >= 2)
            {
                text.text = "";
                SceneManager.LoadScene(4);
            }
        }

    }
}