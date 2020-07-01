using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text text;
    public bool pause;
    float timer;
    bool set;




    void Start()
    {
        timer = 0;
        text = GameObject.Find("timer").GetComponent<Text>();
        pause = true;
        set = false;
        
    }


    void Update()
    {
        
            timer += Time.deltaTime;
            if (timer <= 1) text.text = "3";
            else if (timer <= 2) text.text = "2";
            else if (timer <= 3) text.text = "1";
            else if (timer <= 4) text.text = "Start!";
            else
            {
                text.text = "";
                pause = false;
            if (!set)
            {
                GameObject.Find("scripts").GetComponent<AudioControl>().musicControl = true;
                set = true;
            }
               
        }
        
        
    }
}
